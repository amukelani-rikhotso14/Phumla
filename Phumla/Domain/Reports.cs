using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public string HotelName { get; set; }
        public DateTime ReportDate { get; set; }
        public int RoomsAvailable { get; set; }
        public int RoomsOccupied { get; set; }
        public decimal Revenue { get; set; }
    }

}
