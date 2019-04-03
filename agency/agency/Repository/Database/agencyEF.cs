namespace agency.Repository.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class agencyEF : DbContext
    {
        public agencyEF()
            : base("name=agencyEF")
        {
        }

        public virtual DbSet<tblcustomer> tblcustomers { get; set; }
        public virtual DbSet<tblCustomerAccount> tblCustomerAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
