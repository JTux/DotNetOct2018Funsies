using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_03
{
    class Customer
    {
        public string Name { get; set; }
        public bool HasAccidents { get; set; }
        public int Age { get; set; }
        public decimal Premium { get; set; }

        public Customer(string name, bool hasAccidents, int age, decimal premium)
        {
            Name = name;
            HasAccidents = hasAccidents;
            Age = age;
            Premium = premium;
        }

        public Customer()
        {

        }
    }
}
