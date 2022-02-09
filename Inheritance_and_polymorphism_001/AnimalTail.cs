using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_001
{
    class AnimalTail : Tail
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public AnimalTail(int tailLenght, string type, int age, string color) : base(tailLenght, type)
        {
            Age = age;
            Color = color;
        }
    }
}

