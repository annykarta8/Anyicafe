//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ANYI_Cafe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersDetail
    {
        public int rowid { get; set; }
        public string order_no { get; set; }
        public string vendor_no { get; set; }
        public string category_name { get; set; }
        public string product_no { get; set; }
        public string product_name { get; set; }
        public string product_spec { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<int> amount { get; set; }
        public string remark { get; set; }
    }
}
