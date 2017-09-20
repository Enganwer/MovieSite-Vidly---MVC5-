namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusersa : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'92d09e30-f8b2-47a8-9ad4-bc8f9af0f7bf', N'Admin@Demo.com', 0, N'AH8QYSu6NIWPuzMtZUyxQo5FGbqDoMSddym9yqeUOh2ZMg+h2LsNYfeuGyLhls+oDg==', N'0b0aafa8-7020-437f-ba37-6c616b8223c4', NULL, 0, 0, NULL, 1, 0, N'Admin@Demo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac94bdcb-35b6-495c-aa2c-bc018dfae0e2', N'Guest@demo.com', 0, N'ANut9CDygR5M5ANh0HNdbre8wQse3P0NhQrivtBd7qW1s04ilsBEYtpseAU+eIzGRw==', N'55898c12-7610-4a92-8e7d-bf7b2c845b5c', NULL, 0, 0, NULL, 1, 0, N'Guest@demo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'92d09e30-f8b2-47a8-9ad4-bc8f9af0f7bf', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
        }
        
        public override void Down()
        {
        }
    }
}
