using System.Data.Entity;
using MACARENA.Models.Booking;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ClassLibrary1
{

    public  class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("MacarenaDBLocal", throwIfV1Schema: false)
        {
        }
      

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}