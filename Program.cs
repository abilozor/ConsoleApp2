using System;
using System.Runtime.ConstrainedExecution;
using Lab2Lib;

namespace Lab2App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість автомобілів: ");
            int count = int.Parse(Console.ReadLine());

            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВведіть дані для автомобіля {i + 1}:");
                Car car = new Car();

                Console.Write("Введіть модель автомобіля: ");
                car.ModelName = Console.ReadLine();

                Console.Write("Введіть виробника: ");
                car.Manufacturer = Console.ReadLine();

                Console.Write("Введіть рік випуску: ");
                car.YearOfProduction = int.Parse(Console.ReadLine());

                Console.Write("Введіть об'єм двигуна (л): ");
                car.EngineCapacity = double.Parse(Console.ReadLine());

                Console.Write("Введіть кількість місць: ");
                car.SeatCount = int.Parse(Console.ReadLine());

                Console.Write("Чи є автомобіль електричним (true або false): ");
                car.IsElectric = bool.Parse(Console.ReadLine());

                Console.Write("Введіть середню витрату палива (л/100 км): ");
                car.AverageFuelConsumption = double.Parse(Console.ReadLine());

                cars[i] = car;
            }
            Console.WriteLine("\nВсі автомобілі були успішно створені.");

            foreach (Car c in cars)
            {
                Console.WriteLine();
                Console.WriteLine("Дані про автомобіль:");
                Console.WriteLine("Модель: " + c.ModelName);
                Console.WriteLine("Виробник: " + c.Manufacturer);
                Console.WriteLine("Рік випуску: " + c.YearOfProduction);
                Console.WriteLine("Об'єм двигуна: " + c.EngineCapacity);
                Console.WriteLine("Кількість місць: " + c.SeatCount);
                Console.WriteLine("Електричний: " + c.IsElectric);
                Console.WriteLine("Середня витрата палива (л/100 км): " + c.GetFuelConsumptionPer100Km().ToString("0.00"));
            }

            while (true) Console.ReadKey();
        }
    }
}
