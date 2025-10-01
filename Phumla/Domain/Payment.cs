using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public Booking Booking { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Method { get; set; }
        public string Reference { get; set; }
    }

}
