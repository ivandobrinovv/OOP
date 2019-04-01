using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP42
{
    class Dog : Animal, IAnimal
    {
        public string Talk()
        {
            return "Bark";
        }

        internal override string Sleep(int hoursOfSleep)
        {
            if(IsSleepy)
            {
                return "Zzzzz";
            }

            return "I don't want to sleep";
        }
    }
}
