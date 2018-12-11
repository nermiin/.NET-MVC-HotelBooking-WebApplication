using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MACARENA.Models
{
    public class Hotels
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Hotel Name is required !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "City Name is required !")]
        public string City { get; set; }
        [Required(ErrorMessage = "Price is required !")]
        public int Price { get; set; }
        [Required(ErrorMessage = "aviable rooms is required !")]
        public int Rooms { get; set; }

    }
}