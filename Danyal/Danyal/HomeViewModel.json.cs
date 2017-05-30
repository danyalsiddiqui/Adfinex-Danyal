using Starcounter;

namespace Danyal
{
    partial class HomeViewModel : Json
    {
        protected override void OnData()
        {
            base.OnData();
            getAllCorporation(); // set the list of corporations to display them on  View page
       
        }

        void Handle(Input.AddNewCorporation action)
        {
            //adding New Corporation   
            var corporation = new Corporation()
            {
                Name = NewCorporationName
            };
            AddCorporation(corporation);
            Transaction.Commit();
        }

        public void AddCorporation(Corporation corporation)
        {
            // get partial view and then Add to list that renders it into Main View
            var corporationJson = Self.GET("/Danyal/partial/corporation/" + corporation.GetObjectID());
            this.Corporations.Add(corporationJson);
        }

        public void getAllCorporation()
        {
            // Gets all the Corporations from db to show it in Main page 
            var corporationList = Db.SQL<Corporation>("SELECT e FROM Danyal.Corporation e");
            foreach (var Corporation in corporationList)
            {
                AddCorporation(Corporation);
            }
        }
    }
}
