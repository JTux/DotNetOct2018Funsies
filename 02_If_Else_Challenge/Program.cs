using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_If_Else_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter the age of the car: ");
            string ageAsString = Console.ReadLine();
            int actualAge = int.Parse(ageAsString);

            decimal charge;
            if (actualAge < 5)
            {
                charge = 75.00m;
            }
            //This will only be checked if the first if statement returns false
            //Therefore we only have to check the next condition
            //which, in this case, is that it is less than 15
            else if (actualAge < 15)
            {
                charge = 100.00m;
            }
            //If both <5 and <15 return false, this else will catch all other cases
            else
            {
                charge = 150.00m;
            }

            Console.WriteLine("Enter the amount of miles on the car: ");
            string milesAsString = Console.ReadLine();
            double actualMiles = double.Parse(milesAsString);

            if (actualMiles >= 50000)
            {
                Console.WriteLine("Hello " + userName + ", you will be paying $" + charge + " plus a premium of $25.00.");
                Console.WriteLine($"Hello {userName}, you will be paying {charge} plus");
                charge = charge + 25;
                Console.WriteLine("Your total payment will be $" + charge + ".");
            }
            else
            {
                Console.WriteLine("Hello " + userName + ", you will be paying $" + charge + ".");
            }

            Console.ReadLine();
        }
    }
}
