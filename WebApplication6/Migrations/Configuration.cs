namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication6.Models.AppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication6.Models.AppDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(new Models.UserInfo() { UserName = "admin", Password = "abc123", Role = "Admin" });


            context.Users.AddOrUpdate(new Models.UserInfo() { UserName = "ditc", Password = "123456", Role = "User" });
        }
    }
}
