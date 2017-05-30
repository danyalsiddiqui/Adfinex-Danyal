using Starcounter;

namespace Danyal
{
    partial class FranchiseDetailViewModel : Json
    {
        public string Address => Street + "," + Number + "," + ZipCode + "," + City + "," + Country;

        public string NewHomeAddress => NewHomeStreet + "," + NewHomeNumber + "," + NewHomeZipCode + "," + NewHomeCity + "," + NewHomeCountry;

        protected override void OnData()
        {
            SetFranchiseDetail(); // setting the Franchise Data
            getAllTransactions(); // setting the Transaction Data
            base.OnData();
        }
        public void SetFranchiseDetail()
        {
            var Address = Db.SQL<Address>("Select A FROM Danyal.Address A WHERE A.FranchiseAddress=?", (Franchise)this.Data).First;
            if(Address!= null)  // check if the Address EXist Then Update the View Model To display on View  
            {
                Street = Address.Street;
                Number = Address.Number;
                ZipCode = Address.ZipCode;
                City = Address.City.Name;
                Country = Address.Country.Name;
            }
        }

        public void getAllTransactions()
        {
            var HomeList = Db.SQL<Home>("SELECT h FROM Danyal.Home h where h.SellerFranchise=?", (Franchise)this.Data); // Get All the home whoes transaction is done by Current Franchise
            foreach (var HomeTranscation in HomeList)
            {
                AddHomeTranscation(Db.SQL<TransationInfo>("SELECT T FROM Danyal.TransationInfo T where T.HomeSold=?", HomeTranscation).First); // Add Transaction One by One in the List to display on Screen 
            }
        }

        void Handle(Input.SaveFranchiseAddress action)
        {
            var Address=Db.SQL<Address>("Select A FROM Danyal.Address A WHERE A.FranchiseAddress=?", (Franchise)this.Data).First;
            if (Address == null) // Create New Address  
            {
                var country = Db.SQL<Country>("Select c FROM Danyal.Country c WHERE c.Name=?", Country.ToLower()).First;
                City city;


                #region Create Country And City If not Exist

                if (country == null)
                {
                    country = new Country()
                    {
                        Name = Country.ToLower()
                    };
                    city = new City()
                    {
                        Name = City.ToLower(),
                        Country = country
                    };
                }
                else
                {
                    city = Db.SQL<City>("Select c FROM Danyal.City c WHERE c.Country=?", country).First;
                    if (city == null)
                    {
                        city = new City()
                        {
                            Name = City.ToLower(),
                            Country = country
                        };
                    }
                }

                #endregion

                //Create an object of address for saving the Address of franchise
                var address = new Address()
                {
                    Street = Street,
                    FranchiseAddress = (Franchise)this.Data,
                    Number = Number,
                    ZipCode = ZipCode,
                    Country = country,
                    City = city
                };
                Transaction.Commit();
            }
            else
            {
                UpdateAddress(Address); //Update Existing Address
            }
        }


        void UpdateAddress(Address Address)
        {
            Address.Street = Street;
            Address.Number = Number;
            Address.ZipCode = ZipCode;
            Address.City = Address.City.Name.ToLower() == City.ToLower() ? Address.City : new Danyal.City() {Name=City };             //If the City is new then add 
            Address.Country = Address.Country.Name.ToLower() == Country.ToLower() ? Address.Country : new Country() { Name=Country};  //If the Country is new then add 
            Address.City.Country = Address.Country;
            Transaction.Commit();
        }

        void Handle(Input.SaveTransaction action)
        {
            Transaction.Commit();
            var country = Db.SQL<Country>("Select c FROM Danyal.Country c WHERE c.Name=?", NewHomeCountry.ToLower()).First;
            City city = new City();

            #region Create Country And City If not Exist

            if (country == null)
            {
                country = new Country()
                {
                    Name = NewHomeCountry.ToLower()
                };
                city.Name = NewHomeCity.ToLower();
                city.Country = country;

            }
            else
            {
                city = Db.SQL<City>("Select c FROM Danyal.City c WHERE c.Name=? and c.Country=?", NewHomeCity.ToLower(), country).First;
                if (city == null)
                {
                    city = new Danyal.City()
                    {
                        Name = NewHomeCity.ToLower(),
                        Country = country,
                    };
                }
            }
            #endregion

            //Create Home Object to save the Details of home
            var home = new Home()
            {
                SellerFranchise = (Franchise)this.Data,
            };

            //Create Address Object to save the Details of home
            var address = new Address()
            {
                HomeAddress = home,
                Street = NewHomeStreet,
                Number = NewHomeNumber,
                ZipCode = NewHomeZipCode,
                Country = country,
                City = city
            };

            //Create Transation Object to save the Details of home Transation
            var transaction = new TransationInfo()
            {
                HomeSold = home,
                Date = System.DateTime.Parse(TransactionDate),
                SalePrice = TransactionSalePrice,
                Commission = TransactionCommision
            };
            //add transcation to list to display on View
            AddHomeTranscation(transaction);

            Transaction.Commit();
        }

        void AddHomeTranscation(TransationInfo transaction)
        {
            // get partial view and then Add to list that renders it into Main View
            var TranscationDetailJson = Self.GET("/Danyal/partial/TranscationDetail/" + transaction.GetObjectID());
            this.SoldHomes.Add(TranscationDetailJson);
        }
    }
}
