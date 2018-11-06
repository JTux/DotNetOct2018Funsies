using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Challenge_01b
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Person Owner { get; set; }

        public Car(int year, string make, string model, Person person)
        {
            Year = year;
            Make = make;
            Model = model;
            Owner = person;
        }

        public Car() { }
    }
}
