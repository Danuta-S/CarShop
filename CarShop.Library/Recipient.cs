using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class Recipient
    {
        public Car car { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptName { get; set; }
        public DateTime Date { get; set; }
        public int OdometerReading { get; set; }
        public string LicenseNumber { get; set; }
        public decimal CarPrice { get; set; }
        public int Quantity { get; set; }
    }
}
