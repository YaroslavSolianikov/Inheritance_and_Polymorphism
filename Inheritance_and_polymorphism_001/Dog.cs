using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_001
{
    class Dog : AnimalTail
    {
        public string Name { get; set; }
        public Dog(int tailLenght, string type, int age, string color, string name) : base(tailLenght, type, age, color)
        {
            Name = name;
        }
        public void Info() => Console.WriteLine($"Lenght of tail:{TailLenght}\nType of tail:{Type}\nAge:{Age}\nColor:{Color}\nName:{Name}");
    }
}

