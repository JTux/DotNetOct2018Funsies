using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Challenge_01b
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, int age, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        public Person()
        {

        }
    }
}
