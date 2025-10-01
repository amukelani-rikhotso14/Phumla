using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Status { get; set; }

        public decimal CalculateTotalCost()
        {
            int nights = (DepartureDate - ArrivalDate).Days;
            return nights * Room.RatePerNight;
        }
    }
}
