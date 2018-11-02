using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type  Name  = value
            //Declaring a variable
            bool isTall;

            //isTall = false;
            int age;

            byte low = 0;
            byte high = 255;

            float floating = 123.4123f;
            double number = 123.456d;
            decimal number2 = 12345.35123m;

            //Int16 == short
            //Int64 == long
            long number3 = 123;

            char character = '4';
            string word = "This is a string.";

            //Console.WriteLine("word");
            //Console.WriteLine(word);

            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            Console.WriteLine("What is your first name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string yourLastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string yourAgeAsAString = Console.ReadLine();
            int myIntAge = int.Parse(yourAgeAsAString);

            Console.WriteLine("What is your email?");
            string emailAsString = Console.ReadLine();

            Console.WriteLine("Hello " + yourName + " " + yourLastName + ".");
            Console.WriteLine("You are " + myIntAge + " years old and your email is " + emailAsString);

            Console.ReadLine();
        }
    }
}
