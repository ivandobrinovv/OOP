using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP22
{
    public class Car
    {
        public Car(string brand)
        {
            Brand = brand;
        }

        public Car(int hp)
        {
            HP = hp;
        }

        public Car()
        {

        }

        public Car(int hp, string brand)
        {
            HP = hp;
            Brand = brand;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Vrum vrum");
        }

        public void StartEngine(bool isKeyNeeded)
        {
            if(isKeyNeeded)
            {
                Console.WriteLine("Insert key");
            }
            else
            {
                Console.WriteLine("Click the button");
            }
        }

        public void StartEngine(string password)
        {
            string passwordToUnlock = "veryStrongPass";

            if(password == passwordToUnlock)
            {
                StartEngine();
            }
            else
            {
                Console.WriteLine("Wrong password");
            }

        }

        public override string ToString()
        {
            return $"This is {Brand} with {HP} hp, produced in {YearOfProduction}";
        }

        public int HP { get; set; }

        public string Brand { get; set; }

        public int YearOfProduction { get; set; }
    }

    class Truck : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("I am starting the engin of the truck");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(101, "Audi");
            car.YearOfProduction = 2000;
            Truck truck = new Truck();
            car.StartEngine();
            truck.StartEngine();

            Console.WriteLine(car);
        }
    }
}
