using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class Receipt
    {
        public Car car { get; set; }

        public DateTime Date { get; }
        public string ReceiptNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int OdometerReading { get; set; }
        public string LicenseNumber { get; set; }
        public decimal CarPrice { get; set; }
        public int Quantity { get; set; }

        public Receipt(DateTime date, string receiptNumber, string model, string color, int year, int odometerReading, string licenseNumber, decimal carPrice, int quantity)
        {
            this.Date = date;
            this.ReceiptNumber = receiptNumber;
            this.Model = model;
            this.Color = color;
            this.Year = year;
            this.OdometerReading = odometerReading;
            this.LicenseNumber = licenseNumber;
            this.CarPrice = carPrice;
            this.Quantity = quantity;
        }
    }
}
