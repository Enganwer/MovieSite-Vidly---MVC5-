namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            Sql("update Movies Set Avilabilty = NumberInStock ");
        }
        
        public override void Down()
        {
        }
    }
}
