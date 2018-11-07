using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Josh";
            List<string> listOfStrings = new List<string>();

            List<Pet> listOfPets = new List<Pet>();
            Pet firstPet = new Pet("Ouch", 25, "???", false);
            Pet secondPet = new Pet("Smudge", 4, "Cat", true);
            Pet thirdPet = new Pet("Barkley", 4, "Dog", true);

            listOfPets.Add(firstPet);  //0
            listOfPets.Add(secondPet); //1
            listOfPets.Add(thirdPet);  //2
            listOfPets.Add(firstPet);  //3
            listOfPets.Add(secondPet); //4

            //listOfPets.RemoveAt(4);
            //listOfPets.Remove(firstPet);

            //foreach (Type name in CollectionOfType)
            //{
            // Do this code
            //}

            foreach(Pet pet in listOfPets)
            {
                Console.WriteLine(pet.Name);
            }

            Console.ReadLine();
        }
    }
}
