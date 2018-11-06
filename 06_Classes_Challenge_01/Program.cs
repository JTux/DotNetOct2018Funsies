using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Challenge_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int firstAnswer = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first name: ");
            string secondAnswer = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string thirdAnswer = Console.ReadLine();


            Console.WriteLine("Enter your address: ");
            string fourthAnswer = Console.ReadLine();

            Person newerPerson = new Person()
            {
                FirstName = secondAnswer,
                LastName = thirdAnswer,
                Age = firstAnswer,
                Address = fourthAnswer
            };

            Person newPerson = new Person(secondAnswer, thirdAnswer, firstAnswer, fourthAnswer);
            //newPerson.FirstName = firstAnswer;
            //newPerson.LastName = secondAnswer;
            //newPerson.Age = thirdAnswer;
            //newPerson.Address = fourthAnswer;
            Console.WriteLine($"Hello {newPerson.FirstName} {newPerson.LastName}! You are {newPerson.Age} years old and live at {newPerson.Address}");

            Car newCar = new Car(2019, "Ford", "Explorer", newPerson);

            Console.WriteLine($"Congratulations {newPerson.FirstName}! You are the proud owner of a new {newCar.Year} {newCar.Make} {newCar.Model}! Bully for you!");

            Console.WriteLine($"{newCar.Owner.FirstName}");
            Console.ReadLine();
        }
    }
}
