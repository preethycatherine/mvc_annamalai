namespace agency.Repository.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCustomerAccount")]
    public partial class tblCustomerAccount
    {
        [Key]
        [StringLength(16)]
        public string CID { get; set; }

        public decimal balance { get; set; }

        public DateTime createdOn { get; set; }

        public bool Active { get; set; }

        public DateTime? updatedOn { get; set; }
    }
}
