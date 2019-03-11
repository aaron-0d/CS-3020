using System;
using System.Collections.Generic;
using System.Linq;

namespace FixedMidterm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var menuSelection = 0;
            var machine = new VendingMachine();
            do
            {
                Console.WriteLine("Please enter an integer for the option you want to select:");
                Console.WriteLine("1. Print vending machine.");
                Console.WriteLine("2. List only healthy food and drink.");
                Console.WriteLine("3. List toy options for kids under 7.");
                Console.WriteLine("4. Exit Program");

                menuSelection = int.Parse(Console.ReadLine());

                var exclusions = new List<object>();

                switch (menuSelection)
                {
                    case 1:
                        machine.PrintVendingMachine(new List<VendingMachineOption>());
                        break;
                    case 2:
                        machine.PrintVendingMachine(from o in machine
                            where (o as Food)?.CalorieCount > 100 || (o as Drink)?.CalorieCount > 100
                            select o);

                        break;
                    case 3:
                        machine.PrintVendingMachine(from o in machine
                            where (o as NonElectronic)?.AgeRequirement >= 7 || (o as Electronic)?.AgeRequirement >= 7
                            select o);
                        break;
                    case 4:
                        Console.WriteLine("Thankyou for using this program!");
                        Console.ReadKey();
                        break;
                }
            } while (menuSelection != 4);
        }

        private static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}