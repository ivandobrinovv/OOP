using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Animals
{
    public interface IAnimal
    {
        string Name { get; set; }

        void Walk();
    }
}
