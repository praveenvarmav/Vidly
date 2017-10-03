namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'09fc2220-ad5e-4b2b-8684-c6f4dbd5bc8e', N'guest@vidly.com', 0, N'ANeKtCirm0RJqEJhIoirOjFCwAw4Rdrbx0469u+s/leBMXObGRpI0d8SaWptZCX5tA==', N'159b0bdd-1093-4bdf-9074-2dcd29c4a931', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'375a4cb3-56e7-4b9a-b46d-1b22770df1cf', N'admin@vidly.com', 0, N'AKQ4a62fXNVgD10A3mbBwtPoTj2LQZ7ZFcnvibmRbBYdD67ZGlN/Z44K6AC3ZW1xQw==', N'fd57ebfb-1bd5-4f58-9417-74b98649c969', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2a97aa97-c4e1-4f79-9ae8-a0a32253e4f4', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'375a4cb3-56e7-4b9a-b46d-1b22770df1cf', N'2a97aa97-c4e1-4f79-9ae8-a0a32253e4f4')

");
        }
        
        public override void Down()
        {
        }
    }
}
