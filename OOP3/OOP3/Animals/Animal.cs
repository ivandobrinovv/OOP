using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Animals
{
    class Animal : IAnimal
    {
        public string Name { get; set; } = "Animal";

        public void Walk()
        {
            Console.WriteLine("I am walking");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

    }
}
