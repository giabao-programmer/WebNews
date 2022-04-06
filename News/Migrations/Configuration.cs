namespace DVCP.Migrations
{
    using DVCP.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DVCP.Models.DVCPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DVCPContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.WebInfo.AddOrUpdate(x => x.id,
                new WebInfo
                {
                    id = 1,
                    web_name = "7-Màu",
                    web_des = "Trang web tin tức chính thức của 7-Màu",
                    web_about = "Về 7-Màu",
                }
                );
            context.Users.AddOrUpdate(x => x.username,
                new User
                {
                    username = "admin",
                    password = "0192023A7BBD73250516F069DF18B500", // = admin123
                    fullname = "ADMIN News",
                    userrole = "admin",
                    status = true,
                }
                );
            context.Tags.AddOrUpdate(x => x.TagID,
                new Tag { TagID = 1, TagName = "Game PC" },
                new Tag { TagID = 2, TagName = "Game Moblie" },
                new Tag { TagID = 3, TagName = "Game Console" }
                );
            context.SaveChanges();
        }
    }
}
