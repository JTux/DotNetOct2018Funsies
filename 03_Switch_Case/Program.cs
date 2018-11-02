using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feeling = Console.ReadLine();
            int input = int.Parse(feeling);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Oh no that's terrible");
                    break;
                case 2:
                    Console.WriteLine("Uh oh");
                    break;
                case 3:
                    Console.WriteLine("Good to hear");
                    break;
                case 4:
                    Console.WriteLine("That's good");
                    break;
                case 5:
                    Console.WriteLine("That's great");
                    break;
                default:
                    Console.WriteLine("That is out of range");
                    break;
            }

            Console.ReadLine();


            if (input == 1)
            {
                Console.WriteLine("Oh no that's terrible");
            }
            else if (input == 2)
            {
                Console.WriteLine("Uh oh");
            }
            else if (input == 3)
            {
                Console.WriteLine("That's interesting");
            }
            else if (input == 4)
            {
                Console.WriteLine("That's good");
            }
            else if (input == 5)
            {
                Console.WriteLine("That's great");
            }
            else
            {
                Console.WriteLine("That is out of range");
            }

            //Console.ReadLine();
        }
    }
}
