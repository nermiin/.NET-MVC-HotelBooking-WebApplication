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
      

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}