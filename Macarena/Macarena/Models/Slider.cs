using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MACARENA.Models
{
    public class Slider
    {
            public int ID { get; set; }
            public string SlideText { get; set; }
            public byte[] SlideFoto { get; set; }
            public Nullable<System.DateTime> StartingTime { get; set; }
            public Nullable<System.DateTime> EndDate { get; set; }
    }
}