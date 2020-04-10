namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'62bf06db-f87e-4d69-b1f7-c1ac09e39492', N'guest@gmail.com', 0, N'ACykgSzAJwpWaaYWJW7ucY1MJV2YTlD4JymawBuhDejb+ERa2IFxU0EQYa+lHPpSaQ==', N'e8e16e67-66a6-4d3e-b930-a23de6981038', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ec926085-8079-413e-a628-92873f362904', N'admin@vidly.com', 0, N'ACplnUBftPRV+YwFbZjmLUzygskB8POT7qnTAP7a7y3rW3TE3s/9YEecL7FUIaqNBg==', N'996a1edd-f5e6-46bc-876f-49c093c27362', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fed21f04-a4d2-45fe-a8dc-f0b831bb2c48', N'CanManageMovie')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ec926085-8079-413e-a628-92873f362904', N'9ad1c796-fd42-4c77-be2c-6d6748b3d78e')
            ");


        }

        public override void Down()
        {
        }
    }
}
