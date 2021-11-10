using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class CarOperations : ICarOperations
    {
        //private List<Car> ListOfCars = new List<Car>();
        public Car[] CarArray = new Car[100];

        public void AddCarToTheList(Car car)
        {
            //ListOfCars.Add(car);
            var index = CarArray.Count(x => x != null);
            CarArray[index] = car;
        }

        public int FindAvailableCarsCount()
        {
            return CarArray.Count(x => x != null && x.IsAvailable);
        }

        public Car[] FindCarByYear(int year)
        {
            return CarArray.Where(x => x!= null && x.Year == year).ToArray();
        }

        public void BuyCar(int id)
        {
            var selectedCar = CarArray.FirstOrDefault(x => x.Id == id);

            if (selectedCar != null && selectedCar.IsAvailable)
            {
                selectedCar.Sold = true;
                selectedCar.IsAvailable = false;
            }
        }

        public List<Receipt> PurchasedCars = new List<Receipt>();

        //public string GetReceipt()
        //{//create new class with props
        //    return null;
        //}

        public string GetReceipt(int id)
        {
            var receipt = new StringBuilder();

            receipt.AppendLine("Date\t\tReceipt Number\tModel\tColor\tYear\tOdometer Reading\tLicense Number\tCar Price\tQuantity");
            foreach (var item in PurchasedCars)
            {
                receipt.AppendLine($"{item.Date.ToShortDateString()}\t{item.ReceiptNumber}\t{item.OdometerReading}\t{item.LicenseNumber}\t{item.CarPrice}\t{item.Quantity}");
            }

            return receipt.ToString();
        }

        //public decimal TotalCost(decimal carPrice, int quantity)
        //{
        //    return CarPrice * Quantity;
        //}
    }
}
