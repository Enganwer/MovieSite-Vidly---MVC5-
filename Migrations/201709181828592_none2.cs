namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class none2 : DbMigration
    {
        public override void Up()
        {Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0f1c709d-2ed9-4301-905b-d26b8ee539fd', N'canManageMovies')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [MobilePhone]) VALUES (N'a3f099f4-df40-4cf9-9c64-fdfdde83b13b', N'Admin1@Demo.com', 0, N'ADSAgy7/7xc6+FMm/+pCXLEfoTViU1Vd1e1II9ONjMRMFD8F3V4xoyY/0U8I6tPgmw==', N'e05bc09a-3dd5-4f7d-912d-bb398b0f7138', NULL, 0, 0, NULL, 1, 0, N'Admin1@Demo.com', N'456789', N'11111111111')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [MobilePhone]) VALUES (N'ac94bdcb-35b6-495c-aa2c-bc018dfae0e2', N'Guest@demo.com', 0, N'ANut9CDygR5M5ANh0HNdbre8wQse3P0NhQrivtBd7qW1s04ilsBEYtpseAU+eIzGRw==', N'55898c12-7610-4a92-8e7d-bf7b2c845b5c', NULL, 0, 0, NULL, 1, 0, N'Guest@demo.com', N'', N'')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a3f099f4-df40-4cf9-9c64-fdfdde83b13b', N'0f1c709d-2ed9-4301-905b-d26b8ee539fd')

");
        }
        
        public override void Down()
        {
        }
    }
}
