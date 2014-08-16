namespace Gabric.ZAPostalCodes.ZAPostalCodesWCFService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZAPostalCodesModel : DbContext
    {
        public ZAPostalCodesModel()
            : base("name=ZAPostalCodesModel")
        {
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Suburb> Suburbs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
