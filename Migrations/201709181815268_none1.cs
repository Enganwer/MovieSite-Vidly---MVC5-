namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class none1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bd7e1deb-ae89-4b95-b4c9-59a93eb824e422   ', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [MobilePhone]) VALUES (N'bd7e1deb-ae89-4b95-b4c9-59a93eb824e4   ', N'Admin1@Demo.com', 0, N'AKn+NfBcqlUFZhq2JqOn0Koh6eWYRntDCDpTHe7M8Uoc1p2KMJF+LDPpvEf+Jve12g==', N'1b818e6a-afec-49a0-b3dd-f033e04e969f', NULL, 0, 0, NULL, 1, 0, N'Admin1@Demo.com', N'45679', N'01200972089')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd7e1deb-ae89-4b95-b4c9-59a93eb824e4 ', N'bd7e1deb-ae89-4b95-b4c9-59a93eb824e422')


");
        }
        
        public override void Down()
        {
        }
    }
}
