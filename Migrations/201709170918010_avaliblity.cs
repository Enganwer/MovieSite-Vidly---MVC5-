namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class avaliblity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Avilabilty", c => c.Byte(nullable: false));
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Avilabilty");
        }
    }
}
