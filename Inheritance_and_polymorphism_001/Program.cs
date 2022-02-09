using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(10, "straight", 5, "grey", "Charlie");
            dog.Info();
            Console.ReadKey();
        }
    }
}
