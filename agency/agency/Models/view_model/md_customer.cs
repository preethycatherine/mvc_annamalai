using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace agency.Models.view_model
{
    public class md_customer
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string address1 { get; set; }     
        public string address2 { get; set; }      
        public string  address3 { get; set; }
        public string pincode { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string active { get; set; }
        public DateTime createdon { get; set; }
    }
}