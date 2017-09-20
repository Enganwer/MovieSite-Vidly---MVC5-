namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class none : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bd7e1deb-ae89-4b95-b4c9-59a93eb824e4', N'CanManageMovies')
");
        }
        
        public override void Down()
        {
        }
    }
}
