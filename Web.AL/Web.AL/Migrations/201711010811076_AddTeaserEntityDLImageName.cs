namespace Web.AL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeaserEntityDLImageName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeaserEntityDLs", "ImageName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeaserEntityDLs", "ImageName");
        }
    }
}
