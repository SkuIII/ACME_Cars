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
                Console.WriteLine("Välj vad du vill göra med hjälp av alternativen nedan:\n" +
                                  "1 (Skapa ny kund)\n" +
                                  "2 (Visa antal kunder)\n" +
                                  "3 (Visa lista över alla kunder)\n" +
                                  "4 (Avsluta)");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "N":
                        Console.WriteLine("Add car");
                        break;

                    case "E":
                        Console.WriteLine("Edit existing car");
                        break;

                    case "D":
                        Console.WriteLine("Remove car");
                        break;

                    case "S":
                        Console.WriteLine("Show all cars");
                        break;

                    default:
                        Console.WriteLine("TEST");
                        break;
                }
            }
        }
    }
    class Car
    {
        public string Color;
        public string Price;
        public string Model;
        public string Make;
        public string Year;
    }
}
