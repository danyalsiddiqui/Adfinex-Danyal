using Starcounter;

namespace Danyal
{
    partial class TranscationDetailViewModel : Json
    {
        protected override void OnData()
        {

            Date = ((TransationInfo)this.Data).Date.ToLongDateString();     // setting the Date parameter of transaction to show it on view
            SalePrice = ((TransationInfo)this.Data).SalePrice;              // setting the Sale price parameter of transaction to show it on view
            Commission = ((TransationInfo)this.Data).Commission;            // setting the Commission parameter of transaction to show it on view
            Address = ((TransationInfo)this.Data).HomeSold.AddressString;   // setting the AddressString parameter of transaction to show it on view


            base.OnData();
        }
    }
}
