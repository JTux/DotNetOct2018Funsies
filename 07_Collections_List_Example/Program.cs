using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_List_Example
{
    class Program
    {
        static Person firstPerson = new Person();

        static void Main(string[] args)
        {
            Console.WriteLine("What's your full name?");
            firstPerson.FullName = Console.ReadLine();

            Console.WriteLine("Do you have a car? (y/n)");
            bool addingCars = CheckAnswer();

            while (addingCars)
            {
                RegisterCar();
                Console.WriteLine("Do you want to add another car? (y/n)");
                addingCars = CheckAnswer();
            }

            if (firstPerson.CarList.Count != 0)
            {
                PrintCars();
            }

            Console.ReadLine();
        }

        static bool CheckAnswer()
        {
            bool isValid = false;
            while (!isValid)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            return false;
        }

        static void PrintCars()
        {
            Console.WriteLine($"Here are {firstPerson.FullName}'s registered cars:");
            foreach (Car car in firstPerson.CarList)
            {
                Console.WriteLine($"{car.CarMake} {car.CarModel}");
            }
        }

        static void RegisterCar()
        {
            Car newCar = new Car();
            Console.WriteLine("What is the make of your car?");
            newCar.CarMake = Console.ReadLine();

            Console.WriteLine("What is the model of your car?");
            newCar.CarModel = Console.ReadLine();

            firstPerson.CarList.Add(newCar);
        }
    }
}
