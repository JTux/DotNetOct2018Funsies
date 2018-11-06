using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Challenge_01b
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Ransford", "Walker", 27, "123 home st");

            Person personTwo = new Person();
            personTwo.FirstName = "Kenn";
            personTwo.LastName = "Pascasio";
            personTwo.Age = 30;
            personTwo.Address = "987 main st";

            Person personThree = new Person()
            {
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 45,
                Address = "4545 West st"
            };


            Car carOne = new Car(2019, "Ford", "Explorer", personOne);

            Car carTwo = new Car()
            {
                Year = 1995,
                Make = "Toyota",
                Model = "Corrolla",
                Owner = personThree,
            };

        }
    }
}
