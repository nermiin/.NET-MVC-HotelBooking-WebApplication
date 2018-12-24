namespace MACARENA
{
    using MACARENA.Models;
    using MACARENA.Models.Booking;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MacarenaDBContext : ApplicationDbContext
    {
        // Your context has been configured to use a 'MacarenaDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MACARENA.MacarenaDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MacarenaDBContext' 
        // connection string in the application configuration file.

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}