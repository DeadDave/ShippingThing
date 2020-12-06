using System;

namespace ShippingThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shipping Thing");
            Shipper ShipIT = new Shipper();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Add a (B)aseball Glove");
                Console.WriteLine("Add a Bic(y)cle");
                Console.WriteLine("Add (C)rackers");
                Console.WriteLine("Add a (L)awn Mower");
                Console.WriteLine("List (I)tems to Ship");
                Console.WriteLine("Com(p)ute Charges");
                Console.WriteLine("(Q)uit The Shipping Thing");
                ConsoleKeyInfo theKey = Console.ReadKey();
                Console.WriteLine();
                if (theKey.Key == ConsoleKey.B)
                {
                    bool WasAdded = ShipIT.Add(new BaseBallGlove());
                    if (WasAdded)
                    Console.WriteLine("Baseball Glove added");
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.Y)
                {
                    bool WasAdded = ShipIT.Add(new Bicycle());
                    if (WasAdded)
                        Console.WriteLine("Bicycle Glove added");
                        Console.WriteLine("Any Key to Continue");
                        Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.C)
                {
                    bool WasAdded = ShipIT.Add(new Cracker());
                    if (WasAdded)
                        Console.WriteLine("Crackers added");
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.L)
                {
                    bool WasAdded = ShipIT.Add(new LawnMower());
                    if (WasAdded)
                        Console.WriteLine("Lawn Mower added");
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.I)
                {
                    string myList = ShipIT.Manifest();
                    Console.WriteLine(myList);
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.P)
                {
                    Console.WriteLine("Total:" + ShipIT.getCost());
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Thank you for using The Shipping Thing.");
                    break;
                }
                
            }

        }
    }
}
