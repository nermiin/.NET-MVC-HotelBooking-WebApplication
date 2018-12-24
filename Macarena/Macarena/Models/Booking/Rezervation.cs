using MACARENA.Models.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MACARENA.Models
{
    public class Rezervation
    {
        [Key]
        public int RezervationId { get; set; }

        [Required(ErrorMessage = "Room Name is required !")]
        public string RoomName { get; set; }

        [Required(ErrorMessage = "Check In Date is required !")]
        public DateTime? CheckInDate { get; set; }

        [Required(ErrorMessage = "Check  Out Date is required !")]
        public DateTime? CheckOutDate { get; set; }

        [Required(ErrorMessage = "Adult Number is required !")]
        public int AdultNumber { get; set; }

        [Required(ErrorMessage = "Children Nunmer is required !")]
        public int ChildrenNumber { get; set; }

        public List< Room> Rooms{ get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}