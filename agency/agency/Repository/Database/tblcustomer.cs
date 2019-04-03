namespace agency.Repository.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblcustomer")]
    public partial class tblcustomer
    {
        [Key]
        [StringLength(16)]
        public string CID { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [Required]
        [StringLength(10)]
        public string phone { get; set; }

        [Required]
        [StringLength(150)]
        public string address1 { get; set; }

        [StringLength(150)]
        public string address2 { get; set; }

        [StringLength(150)]
        public string address3 { get; set; }

        [StringLength(150)]
        public string state { get; set; }

        [StringLength(150)]
        public string district { get; set; }

        [StringLength(6)]
        public string pincode { get; set; }

        public bool active { get; set; }

        public DateTime createdon { get; set; }
    }
}
