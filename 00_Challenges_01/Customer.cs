using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges_01
{
    class Customer
    {
        public Customer(string name, int age, string email, string phone)
        {
            Name = name;
            Age = age;
            Email = email;
            PhoneNumber = phone;
        }
        public Customer() { }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public List<Movie> FavoriteMovies { get; set; }
    }
}
