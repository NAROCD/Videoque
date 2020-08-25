namespace Videoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [OP], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'190b89c1-2154-41ee-a00b-eca180c01166', N'000000000', N'admin@videoque.com', 0, N'AN6Gky5ugc0Mzk3jUgzcU803MJfSa5tc/Fp3EwdAaQJkbyfbjJRBOFh/ivhwcY2kTQ==', N'4841082f-473c-448a-8cf8-2dc8ee736b51', NULL, 0, 0, NULL, 1, 0, N'admin@videoque.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [OP], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ea80f162-f2aa-443f-ae77-44d086f2fc8c', N'000000000', N'guest@videoque.com', 0, N'AIYrCch+SFq7Ow9+e4Tqqiu/U/qgu3LPlBbHPcze+NBmhGXoxDBFT6xFqgGhQ39GoQ==', N'07a90493-699d-4819-84bc-46468c6f7c2a', NULL, 0, 0, NULL, 1, 0, N'guest@videoque.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d6d4db8-fafb-491e-be70-612109a1d229', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'190b89c1-2154-41ee-a00b-eca180c01166', N'5d6d4db8-fafb-491e-be70-612109a1d229')

                
        ");
        }
        
        public override void Down()
        {
        }
    }
}
