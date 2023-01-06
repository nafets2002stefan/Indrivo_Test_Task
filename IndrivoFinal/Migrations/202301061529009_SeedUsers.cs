namespace IndrivoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'391c4dad-4817-4643-b484-8352f1d1467f', N'guest1@gmail.com', 0, N'ABfvuRJE/Fmx2gFVpSfG2TuKn7aOYT5pwd4boD8Zq861MzTMw3reOwFsv2PFd0+bMw==', N'21e58148-357f-480b-a4b9-b14c36af6bd7', N'+37369528723', 0, 0, NULL, 0, 0, N'guest1')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a8c087f-07c5-4c85-9302-71eb3a666156', N'admin1@gmail.com', 0, N'AEHHsZPdUrLi+G7J8yTFYJcPknTbD2YFsUe5lQaWV5rOKYzspFC5c9HzB9G6ksvPpg==', N'492b5503-e5dd-4135-8a34-5f2dd757a784', N'+3737812321', 0, 0, NULL, 0, 0, N'admin1')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a5e99143-2198-4e51-9ec4-a2d50a5ed135', N'AdminRole')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9a8c087f-07c5-4c85-9302-71eb3a666156', N'a5e99143-2198-4e51-9ec4-a2d50a5ed135')

");
        }
        
        public override void Down()
        {
        }
    }
}
