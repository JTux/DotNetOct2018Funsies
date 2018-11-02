using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ransford = new Customer("Ransford", true, 27, 150m);

            //ransford.Age = 27;
            //ransford.HasAccidents = true;
            //ransford.Name = "Ransford";
            //ransford.Premium = 150m;

            Console.WriteLine($"Hello {ransford.Name} your premium is ${ransford.Premium}.");

            Customer josh = new Customer();

            josh.Name = "Josh";
            Console.ReadLine();
        }
    }
}
