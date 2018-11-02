using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string ageAsString = Console.ReadLine();
            int actualAge = int.Parse(ageAsString);

            if (actualAge < 18)
            {
                Console.WriteLine("Hey there kid.");
            }
            else if (actualAge == 18)
            {
                Console.WriteLine("Is 18");
            }
            else
            {
                Console.WriteLine("Not 18");
            }

            // && And
            if (actualAge > 18 && actualAge < 65)
            {
                Console.WriteLine("And condition");
            }

            // \ ||
            // || Or
            if (actualAge < 18 || actualAge > 25)
            {

            }
        }
    }
}
