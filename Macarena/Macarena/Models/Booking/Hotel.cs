using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MACARENA.Models.Booking;

namespace MACARENA.Models
{
    public class Hotel
    {

        [Key]
        public string HotelName { get; set; }

        [Required(ErrorMessage = "Hotel ID is required !")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "City Name is required !")]
        public string CityName { get; set; }

        public City City { get; set; }
        public ICollection<Room> Rooms { get; set; }
        
    }
}