using System;

namespace lab_5
{
    class Plane
    {
        public string Name;
        public string Color;
        public string Engine;
        public int Weight;
        public int CountPassengers;
        public int CountFuel;
        public bool HasSpecialBagsSection;
        
        public int FullWeight()
        {
            return (CountPassengers*80) + Weight;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the plane: ");
            string sName = Console.ReadLine();
            Console.Write("Enter the color of the plane: ");
            string sColor = Console.ReadLine();
            Console.Write("Enter the type of the engine: ");
            string sEngine = Console.ReadLine();
            Console.Write("Enter the normal weight of the plane: ");
            string sWeight = Console.ReadLine();
            Console.Write("Enter the count of passengers: ");
            string sCountPassengers = Console.ReadLine();
            Console.Write("Enter the count of fuel: ");
            string sCountFuel = Console.ReadLine();
            Console.Write("Does the plane has the special bag section? (y-yes, n-no): ");
            ConsoleKeyInfo sHasSpecialBagsSection = Console.ReadKey();
            Console.WriteLine();
          
            Plane OurTown = new Plane();
            OurTown.Name = sName;
            OurTown.Color = sColor;
            OurTown.Engine = sEngine;
            OurTown.Weight = int.Parse(sWeight);
            OurTown.CountPassengers = int.Parse(sCountPassengers);
            OurTown.CountFuel = int.Parse(sCountFuel);
            OurTown.HasSpecialBagsSection = sHasSpecialBagsSection.Key == ConsoleKey.Y ? true : false;
            int sFullWeight = OurTown.FullWeight();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Data about the object: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Name: " + OurTown.Name);
            Console.WriteLine("Color: " + OurTown.Color);
            Console.WriteLine("Engine: " + OurTown.Engine);
            Console.WriteLine("Weight: " + OurTown.Weight.ToString());
            Console.WriteLine("Count of passengers: " + OurTown.CountPassengers.ToString());
            Console.WriteLine("Count of fuel: " + OurTown.CountFuel.ToString());
            Console.WriteLine(OurTown.HasSpecialBagsSection ? "Plane have special bag section" : "Plane haven't special bag section");
            Console.WriteLine();
            Console.WriteLine("The full weight is: " + OurTown.FullWeight().ToString());
            Console.ReadKey();
        }
    }
}
