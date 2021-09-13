using System;
using System.Collections.Generic;

namespace ACMEcars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>(); 

            while (true)
            {
                Console.WriteLine("Choose an option below:\n" +
                                  "A (Add car)\n" +
                                  "E (Edit existing car)\n" +
                                  "R (Remove car)\n" +
                                  "S (Show all cars)\n" +
                                  "X (Exit)");
                string option = Console.ReadLine().ToUpper();
                
                switch (option)
                {
                    case "A":
                        Console.WriteLine("Enter the color of the car:");
                        string carColor = Console.ReadLine();
                        Console.WriteLine("Enter the price:");
                        string carPrice = Console.ReadLine();
                        Console.WriteLine("Enter the model:");
                        string carModel = Console.ReadLine();
                        Console.WriteLine("Enter the year the car was manufactured:");
                        string carAge = Console.ReadLine();

                        myCars.Add(new Car() { Color = carColor, Price = carPrice, Model = carModel, Year = carAge});

                        Console.Clear();
                        Console.WriteLine($"New car \"{carColor} {carAge} {carModel}\" has been added!");
                        break;

                    case "E":
                        Console.WriteLine("Edit existing car");
                        break;

                    case "R":
                        Console.WriteLine("Remove car");
                        break;

                    case "S":
                        Console.WriteLine("Show all cars");
                        break;

                    case "X":
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("You can only enter the options N, E, D, S or X!");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
    class Car
    {
        public string Color;
        public string Price;
        public string Model;
        public string Year;
    }
}
