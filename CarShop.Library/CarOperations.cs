using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    public class CarOperations : ICarOperations
    {
        UserOutput uo = new UserOutput();
        private List<Car> ListOfCars = new List<Car>();
        //public Car[] CarArray = new Car[100];

        public void AddCarToTheList(Car car)
        {
            var carList = new List<Car>();
            ListOfCars.Add(car);
            //var index = CarArray.Count(x => x != null);
            //CarArray[index] = car;
        }

        public void FindAvailableCarsCount()
        {
            Console.WriteLine($"Available car count is: {ListOfCars.Count(x => x is {IsAvailable: true })}");
        }

        public Car[] FindCarByYear(int year)
        {
            return ListOfCars.Where(x => x!= null && x.Year == year).ToArray();
        }

        public void BuyCar(int id)
        {
            var selectedCar = ListOfCars.FirstOrDefault(x => x.Id == id);

            if (selectedCar != null)
            {
                selectedCar.Sold = true;
                selectedCar.IsAvailable = false;

                Console.WriteLine(
                    $"Congratulations with purchasing car : {selectedCar.Model}. Would you like to receive a receipt (Yes/No)?");
                
                var acceptReceipt = Console.ReadLine() == "Yes";

                if (acceptReceipt)
                {
                    Console.WriteLine(GetReceipt(selectedCar));
                }
            }
            else
            {
                Console.WriteLine($"There is no car with id: {id}");
            }
        }

        //public List<Receipt> PurchasedCars = new List<Receipt>();

    public string GetReceipt(Car car)
    {
        var receipt = new Recipient()
        {
            car = car,
            Date = DateTime.Now,
            ReceiptNumber = Guid.NewGuid().ToString(),
            ReceiptName = "Car selling receipt",
            OdometerReading = 120000,
            LicenseNumber = "KZ-2165",
            CarPrice = 5000,
            Quantity = 1,

        };

        return @$"
                        Receipt number: {receipt.ReceiptNumber}
                        Receipt name: {receipt.ReceiptName}
                        Model: {receipt.car.Model}
                        Year: {receipt.car.Year}
                        Color: {receipt.car.Color}
                        Date: {receipt.Date.Date}
                        Odometer Reading: {receipt.OdometerReading}
                        License Number: {receipt.LicenseNumber}
                        Car Price: {receipt.CarPrice}
                        Quantity: {receipt.Quantity}

                     ";
    }
            //var receipt = new StringBuilder();

            //receipt.AppendLine("Date\t\tReceipt Number\tModel\tColor\tYear\tOdometer Reading\tLicense Number\tCar Price\tQuantity");
            //foreach (var item in PurchasedCars)
            //{
            //    receipt.AppendLine($"{item.Date.ToShortDateString()}\t{item.ReceiptNumber}\t{item.OdometerReading}\t{item.LicenseNumber}\t{item.CarPrice}\t{item.Quantity}");
            //}

            //return receipt.ToString();

        //public decimal TotalCost(decimal carPrice, int quantity)
        //{
        //    return CarPrice * Quantity;
        //}

        public void ShowMenu()
        {
            uo.UserOutputMethod();
        }

        public Car CreateCarObject(int id)
        {
            var car = new Car
            {
                Id = id
            };

            uo.UserOutputMethod(1);
            car.Model = Console.ReadLine();

            uo.UserOutputMethod(1, 2);
            car.Color = Console.ReadLine();

            uo.UserOutputMethod(1, 2, 3);
            car.Year = Convert.ToInt32(Console.ReadLine());

            return car;
        }

        public void AddCarToTheList()
        {
            int id = 0;
            var continues = true;

            while (continues)
            {
                var car = CreateCarObject(id);
                AddCarToTheList(car);

                uo.UserOutputMethod(1, 2, 3, 4);

                var yesNo = Console.ReadLine();
                if (yesNo != "Yes")
                {
                    continues = false;
                    ShowMenu();
                }

                id++;
            }
        }

        public void GetCarByYear()
        {
            Console.WriteLine("Please provide year");
            var year = Convert.ToInt32(Console.ReadLine());
            var carArray = FindCarByYear(year);

            foreach (var car in carArray)
            {
                Console.WriteLine($"Found car Id: {car.Id} model: {car.Model}");
            }
        }

        public void ShowListOfAllCars()
        {
            int i = 0;

            foreach (var car in ListOfCars)
            {
                if (car != null)
                {
                    Console.WriteLine($"{i}. Car with Id {car.Id} model: {car.Model} / Color: {car.Color} / Year: {car.Year}");
                }

                i++;
            }
        }

        public void BuyCar()
        {
            uo.UserOutputMethod(1, 2, 3, 4, 5);
            var carId = Convert.ToInt32(Console.ReadLine());

            BuyCar(carId);
        }
    }
}
