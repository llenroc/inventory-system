using InventoryManagementSystemMVC.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InventoryManagementSystemMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    internal sealed class Configuration : DbMigrationsConfiguration<InventoryManagementSystemMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InventoryManagementSystemMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
//            var UserManager = new ApplicationUserManager(new UserStore<ApplicationUser>());
//            var user = new ApplicationUser { UserName = "Admin", Email = "admin@ims.com" };
//            var result = UserManager.CreateAsync(user,"123456");
           
            
        }
    }
}