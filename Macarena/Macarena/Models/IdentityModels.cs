using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using MACARENA.Models.Booking;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MACARENA.Models
{
  
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
     

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            
            return userIdentity;
        }
    }
}
///*namespace MACARENA.Migrations
//{
//    using MACARENA.Models;
//    using Microsoft.AspNet.Identity;
//    using Microsoft.AspNet.Identity.EntityFramework;
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<MACARENA.Models.ApplicationDbContext>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = true;
//            AutomaticMigrationDataLossAllowed = true;
//        }

//        protected override void Seed(MACARENA.Models.ApplicationDbContext context)
//        {
//            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

//            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

//            var user = new ApplicationUser()
//            {
//                Email = "adminn@gmail.com",     
//                BirthDate = DateTime.Now.AddYears(-3)
//            };

//            manager.Create(user, "Adminn123.");


//                roleManager.Create(new IdentityRole { Name = "SuperAdmin" });
//                roleManager.Create(new IdentityRole { Name = "Admin" });
//                roleManager.Create(new IdentityRole { Name = "User" });


//            var adminUser = manager.FindByEmail("nermin@gmail.com");

//            manager.AddToRoles(adminUser.Id, new string[] { "SuperAdmin", "Admin" });
//        }
//    }
//}
///*