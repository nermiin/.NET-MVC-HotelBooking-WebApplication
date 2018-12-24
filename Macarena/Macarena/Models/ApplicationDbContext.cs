using System.Data.Entity;
using MACARENA.Models.Booking;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MACARENA.Models
{
    public  class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("MacarenaDBContext", throwIfV1Schema: false)
        {
        }
       
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }

        public DbSet<Blog> Blog { get; set; }
      

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}