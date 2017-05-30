using System;
using Starcounter;

namespace Danyal
{
    #region Database Classes
    //Model  Corporation
    [Database]
    public class Corporation
    {
        public string Name;
        public QueryResultRows<Franchise> Franchises => Db.SQL<Franchise>("Select e FROM Danyal.Franchise e WHERE e.corporation=?", this);
    }

    //Model  Franchise
    [Database]
    public class Franchise
    {
        public Corporation Corporation;
        public string Name;
        public Address Address;
        public string UrlId;
        public QueryResultRows<Home> HomeSold => Db.SQL<Home>("Select h FROM Danyal.Home h WHERE h.SellerFranchise=?", this);
        public long NoOfHomesSold => Db.SQL<long>("SELECT count(h) FROM   Danyal.Home h  WHERE h.SellerFranchise=?", this).First;
        public long TotalCommission=> Db.SQL<long>("SELECT Sum(t.Commission) FROM   Danyal.Home h , Danyal.TransationInfo t   WHERE h.SellerFranchise=?  AND t.HomeSold=h", this).First;
        public decimal AverageCommision => Db.SQL<decimal>("SELECT Sum(t.Commission)/count(t.Commission) FROM   Danyal.Home h , Danyal.TransationInfo t   WHERE h.SellerFranchise=?  AND t.HomeSold=h", this).First;
        public long Trend;
    }

    //Model  Home
    [Database]
    public class Home
    {
        public Franchise SellerFranchise;
        public Address AddressObj => Db.SQL<Address>("Select A FROM Danyal.Address A WHERE A.HomeAddress=?", this).First;
        public string AddressString => AddressObj.Street + "," + AddressObj.Number + "," + AddressObj.ZipCode + "," + AddressObj.City.Name + "," + AddressObj.Country.Name;

    }

    //Model  TransationInfo
    [Database]
    public class TransationInfo
    {
        public Home HomeSold;
        public DateTime Date;
        public long SalePrice;
        public long Commission;
    }

    //Model  Address
    [Database]
    public class Address
    {
        public Home HomeAddress;
        public Franchise FranchiseAddress;
        public string Street;
        public long Number;
        public long ZipCode;
        public City City;
        public Country Country;
    }

    //Model  Country
    [Database]
    public class Country
    {
        public string Name;
        public QueryResultRows<City> Cities => Db.SQL<City>("Select c FROM Danyal.City c WHERE c.Country=?", this);
    }

    //Model  City
    [Database]
    public class City
    {
        public Country Country;
        public string Name;
    }

    #endregion


    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/Danyal/Home", () => {
                return Db.Scope(() =>
                {
                    var Corporations = Db.SQL<Corporation>("SELECT e FROM Danyal.Corporation e");
                    var json = new HomeViewModel { Data = Corporations };
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });

            });

            // return partial View for Corporation
            Handle.GET("/Danyal/partial/corporation/{?}", (string id) => {
                var json = new CorporationViewModel();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });



            // return partial View for Franchise
            Handle.GET("/Danyal/partial/Franchise/{?}", (string id) => {
                var json = new FranchiseViewModel();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });

            // return partial View for Franchise Detail
            Handle.GET("/Danyal/partial/FranchiseDetail/{?}", (string id) => {

                return Db.Scope(() =>
                {
                    var json = new FranchiseDetailViewModel();
                    json.Name = ((Franchise)DbHelper.FromID(DbHelper.Base64DecodeObjectID(id))).Name;
                    json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });
            });

            // return partial View for Transcation Detail
            Handle.GET("/Danyal/partial/TranscationDetail/{?}", (string id) => {
                var json = new TranscationDetailViewModel();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });

        }
    }
}