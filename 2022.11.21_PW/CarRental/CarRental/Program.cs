using System.Diagnostics.CodeAnalysis;

namespace CarRental
{
    internal class Program
    {
        static void Main()
        {
            RentaledCar car = new RentaledCar
            {
                Model = "Honda Accord",
                RegistrationNumber = "123AS",
                PricePerDays = 1000,
                MaxMiles = 1000
            };

            SaleRentaledCarDecorator saledRentaledCar = new(car);
            saledRentaledCar.SetSale(0.7);
            Console.WriteLine($"Price Per Days on Saled Rentaled Car = {saledRentaledCar.PricePerDays}");
            saledRentaledCar.PricePerDays = 1500;
            saledRentaledCar.SetSale(0.5);
            Console.WriteLine($"Price Per Days on Saled Rentaled Car = {saledRentaledCar.PricePerDays}");

            ListRentersRentaledCarDecorator rentaledCarWithRenters = new(saledRentaledCar); //Decorator wrap example with other decorator
            rentaledCarWithRenters.Renters.Add("Vasya");
            Console.WriteLine($"Price Per Days on Saled Rentaled Car With Renters List = {rentaledCarWithRenters.PricePerDays}");
            Console.WriteLine($"First renter from renters list on Saled Rentaled Car With Renters List = {rentaledCarWithRenters.Renters[0]}");
        }
    }

    interface IRentaledCar
    {
        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public double PricePerDays { get; set; }

        public int MaxMiles { get; set; }
    }

    class RentaledCar : IRentaledCar //Component
    {
        public required string Model { get; set; }

        public required string RegistrationNumber { get; set; }

        public required double PricePerDays { get; set; }

        public required int MaxMiles { get; set; }
    }

    abstract class RentaledCarDecorator : IRentaledCar //Decorator
    {
        protected IRentaledCar rentaledCar;

        public RentaledCarDecorator(IRentaledCar rentaledCar)
        {
            this.rentaledCar = rentaledCar;
        }

        public string Model
        {
            get => rentaledCar.Model;
            set => rentaledCar.Model = value;
        }
        public string RegistrationNumber
        {
            get => rentaledCar.RegistrationNumber;
            set => rentaledCar.RegistrationNumber = value;
        }
        public double PricePerDays
        {
            get => rentaledCar.PricePerDays;
            set => rentaledCar.PricePerDays = value;
        }
        public int MaxMiles
        {
            get => rentaledCar.MaxMiles;
            set => rentaledCar.MaxMiles = value;
        }
    }

    class SaleRentaledCarDecorator : RentaledCarDecorator //Concrete Decorator
    {
        public SaleRentaledCarDecorator(IRentaledCar rentaledCar) : base(rentaledCar)
        {
        }

        public void SetSale(double sale)
            => this.rentaledCar.PricePerDays *= sale;
    }

    class ListRentersRentaledCarDecorator : RentaledCarDecorator //Concrete Decorator
    {
        public ListRentersRentaledCarDecorator(IRentaledCar rentaledCar) : base(rentaledCar)
        {
            Renters = new();
        }

        public List<string> Renters { get; set; }
    }


}