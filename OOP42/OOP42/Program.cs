using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferanceSample;

namespace OOP42
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();

            double a = 6.8;
            object b = a;
            int c = (int)(double)b;
            Console.WriteLine(c);
        }
    }
}
