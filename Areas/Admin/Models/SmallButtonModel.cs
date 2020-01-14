using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Web;

namespace Memberships.Areas.Admin.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }

        public int? Id { get; set; }
        public int? ItemId { get; set; }
        public int? ProductId { get; set; }
        public int? SubscriptionId { get; set; }
        public string ActionParameters {
            get {
                var param = new System.Text.StringBuilder("?");
                if (Id != null && Id > 0)
                    param.Append(String.Format("{0}={1}&", "id", Id));


                if (ItemId != null && ItemId > 0)
                    param.Append(String.Format("{0}={1}&", "itemid", ItemId));


                if (ProductId != null && ProductId > 0)
                    param.Append(String.Format("{0}={1}&", "productid", ProductId));


                if (SubscriptionId != null && SubscriptionId > 0)
                    param.Append(String.Format("{0}={1}&", "subscriptionid", SubscriptionId));
                return param.ToString().Substring(0, param.Length - 1);
            }  }
    }
}