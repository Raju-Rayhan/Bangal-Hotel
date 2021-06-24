using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Room
    {
        public int SN { get; set; }
        public string Room_Name { get; set; }
        public string Room_No { get; set; }
        public string Room_Type { get; set; }
        public string Bed_No { get; set; }
        public string Floor_No { get; set; }
        public string Available { get; set; }
        public float Price { get; set; }
        public float DiscountAmt { get; set; }
        public string Cupon { get; set; }
    }
}
