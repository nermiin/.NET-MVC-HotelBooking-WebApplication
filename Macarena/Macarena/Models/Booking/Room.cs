using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MACARENA.Models
{
    public class Room
    {
      
        [Key]
        public string  RoomName { get; set; }
        public  int  RoomId { get; set; }

        [Required(ErrorMessage = "Room Status is required !")]
        public string  RoomStatus { get; set; }

        [Required(ErrorMessage = "Bed Size is required !")]
        public BedType BedSize { get; set; }

        [Required(ErrorMessage = "Price is required !")]
        public int Price { get; set; }

        public Hotel Hotel { get; set; }
        public Rezervation Rezervations { get; set; }

    }
    public enum BedType
    {
        Single,
        Twin
    }
}