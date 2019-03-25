using OOP3.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Singleton
    {
        private static Singleton Instance { get; set; }

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }
    }

    public abstract class AbstractClass
    {
        public void DoSth()
        {
            //Do sth
        }

        public abstract void DoSthElse();
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Animal();
            animal.Walk();
        }
    }
}
