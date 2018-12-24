using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MACARENA.Models.Booking
{
    public class City
    {
        [Key]
        public string CityName { get; set; }
     

        [Required(ErrorMessage = "City Id is required !")]
        public int ID { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
    }
}