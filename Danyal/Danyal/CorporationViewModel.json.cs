using Starcounter;

namespace Danyal
{
    partial class CorporationViewModel : Json
    {
        protected override void OnData()
        {
            base.OnData();
            getAllFranchies();
        }

        public void getAllFranchies()
        {
            // get all the Franchies of particular Corporation and then added it into list to show it on View
            var FranchiesList = Db.SQL<Franchise>("SELECT f FROM Danyal.Franchise f where f.Corporation=?", (Corporation)this.Data);
            foreach (var Franchies in FranchiesList)
            {
                AddFranchise(Franchies);
            }
        }

        void Handle(Input.AddNewFranchies action)
        {
            //Create new Franchise
            var Franchise = new Franchise()
            {
                Name = FranchiesName,
                Corporation = (Corporation)this.Data,
            };
            Franchise.UrlId = Franchise.GetObjectID();
            AddFranchise(Franchise);                      // add it into list to display it on view
            Transaction.Commit();
        }

        public void AddFranchise(Franchise Franchise)
        {
            // get partial view and then Add to list that renders it into Main View
            var FranchiseJson = Self.GET("/Danyal/partial/Franchise/" + Franchise.GetObjectID());
            this.Franchies.Add(FranchiseJson);
        }

        void Handle(Input.SortByNoOfHomes action)
        {
            // Sorting by No of homes 
            var franchiseList = Db.SQL<Franchise>("Select f FROM Danyal.Franchise f WHERE f.Corporation=? Order by NoOfHomesSold Desc", (Corporation)this.Data);
            Franchies.Clear();
            foreach (var franchise in franchiseList)
            {
                AddFranchise(franchise);
            }
        }
        void Handle(Input.SortByTotalCommission action)
        {
            // Sorting by total Commission
            var franchiseList = Db.SQL<Franchise>("Select f FROM Danyal.Franchise f WHERE f.Corporation=? Order by TotalCommission Desc", (Corporation)this.Data);
            Franchies.Clear();
            foreach (var franchise in franchiseList)
            {
                AddFranchise(franchise);
            }
        }


        void Handle(Input.SortByAvgCommission action)
        {
            // Sorting by Avg Commission
            var franchiseList = Db.SQL<Franchise>("Select f FROM Danyal.Franchise f WHERE f.Corporation=? Order by AverageCommision Desc", (Corporation)this.Data);
            Franchies.Clear();
            foreach (var franchise in franchiseList)
            {
                AddFranchise(franchise);
            }
        }
        void Handle(Input.SortByTrend action)
        {
            // Sorting by Trend
            var franchiseList = Db.SQL<Franchise>("Select f FROM Danyal.Franchise f WHERE f.Corporation=? Order by Trend Desc", (Corporation)this.Data);
            Franchies.Clear();
            foreach (var franchise in franchiseList)
            {
                AddFranchise(franchise);
            }
        }

    }
}
