using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Challenge_01
{
    class Program
    {
        static Car car1;
        static Car car2;

        static void Main(string[] args)
        {
            car1 = new Car(1995);
            car2 = new Car(2018);

            SeeCarInfo(car1);
            SeeCarInfo1();
            SeeCarInfo(car2);
            SeeCarInfo2();

            Console.ReadLine();
        }

        static void SeeCarInfo(Car car)
        {
            Console.WriteLine($"This car was made in: {car.Year}");
        }

        static void SeeCarInfo1()
        {
            Console.WriteLine($"This car was made in: {car1.Year}");
        }
        static void SeeCarInfo2()
        {
            Console.WriteLine($"This car was made in: {car2.Year}");
        }
    }
}
