namespace Bidyo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c00e8ba5-e3e7-4c6a-b56d-96a3634652f1', N'guest@bidyo.com', 0, N'AExIvf49Jpz3y77tW1GBj30YjkJHSK4SV7nlCtNprWONrZ+mPHgqu9Y1nq/oRztKQw==', N'b5c8dc7b-c50d-485b-a35a-5e839b9a9003', NULL, 0, 0, NULL, 1, 0, N'guest@bidyo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e836556b-2520-4cbc-8a56-507b19669c17', N'admin@bidyo.com', 0, N'AGpo2p8Bmkuw7c0Cvq8YiHZxEr4JgINaEdPXW69xhJYsSalfQt1h9bS9cYlkkBPFBg==', N'555cedf9-842b-439b-9c2f-a29fad67d6b5', NULL, 0, 0, NULL, 1, 0, N'admin@bidyo.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'74a58933-ce55-4bc7-bb45-240df6452560', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e836556b-2520-4cbc-8a56-507b19669c17', N'74a58933-ce55-4bc7-bb45-240df6452560')
");
        }
        
        public override void Down()
        {
        }
    }
}
