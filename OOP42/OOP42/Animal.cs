using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP42
{
    public abstract class Animal
    {
        public int LegsCount { get; set; }

        public bool IsHungry { get; set; }

        public bool IsSleepy { get; set; }

        private string Eat(string food)
        {
            if(IsHungry)
            {
                return $"I am eating {food}";
            }

            return "I am not hungry";
        }

        internal abstract string Sleep(int hours);
    }
}
