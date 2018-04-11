using System.Data.Entity;

namespace Web.DL
{
    public class EntityFramework:DbContext
    {
        public DbSet<HeaderEntityDL> HeaderEntityDLTable { get; set; }
        public DbSet<FooterEntityDL> FooterEntityDLTable { get; set; }
        public DbSet<TeaserEntityDL> TeaserEntityDLTable { get; set; }

        public EntityFramework():base("DefaultConnection")
        { }
    }
}
