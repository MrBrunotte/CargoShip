using System;

namespace CargoShipLoader
{
    class Program
    {
        static void Main(string[] args)
        {

            Ship ship = new Ship();

            string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its maximum capacity by adding motorcycles, cars, trucks and trains. A cycle takes 3 units of weight, a car takes 5 units of weight, a truck takes 11 units of weight, and a train car takes 17 units of weight.";

            Console.WriteLine(WelcomeMessage);

            // repeat until the user gets the ship loaded to capacity
            while (ship.Capacity != ship.GetShipLoad())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"The ships capacity is: {ship.Capacity}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"The ship has {ship.CycleCount} + motorcycles onboard");
                Console.WriteLine($"The ship has {ship.CarCount} + cars onboard");
                Console.WriteLine($"The ship has {ship.TruckCount} + trucks onboard");
                Console.WriteLine($"The ship has {ship.TrainCarCount} + traincars onboard");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The ship currently has {ship.GetShipLoad()} + total units onboard");
                Console.ForegroundColor = ConsoleColor.White;
               
                int x;
                Console.WriteLine("How many motorcycles would you like to put on the ship? ");
                x = int.Parse(Console.ReadLine());
                ship.CycleCount = x;

                Console.WriteLine("How many cars would you like to put on the ship? ");
                x = int.Parse(Console.ReadLine());
                ship.CarCount = x;

                Console.WriteLine("How many trucks would you like to put on the ship? ");
                x = int.Parse(Console.ReadLine());
                ship.TruckCount = x;

                Console.WriteLine("How many traincars would you like to put on the ship? ");
                x = int.Parse(Console.ReadLine());
                ship.TrainCarCount = x;

                Console.WriteLine($"The ship now has {ship.GetShipLoad()} total units of weight");

                if (ship.OverUnder() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The ship still has more room to spare, load more items!");
                }
                if (ship.OverUnder() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("To much weight, reload!");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You loaded the ship successfully!");


            Console.ReadLine();
        }
    }
}
