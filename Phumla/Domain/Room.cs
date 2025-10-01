using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string HotelName { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal RatePerNight { get; set; }
        public bool IsAvailable { get; set; }
    }
}
