using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder() { Height = 4, Square = 5 };
            Pyramid pyramid = new Pyramid() { Height = 3, Square = 5 };
            Ball ball = new Ball() { Radius = 3 };

            Box box = new Box() { DrawerVolume = 100 };
            double sum = box.VolumeShapes(pyramid) + box.VolumeShapes(cylinder) + box.VolumeShapes(ball);
            Console.WriteLine($"Sum of all shapes: {sum}");
            Console.WriteLine($"Volume of box: {box.DrawerVolume}");
            Console.WriteLine();
            Console.WriteLine(box.Add(sum));
            Console.ReadKey();
        }
    }
}
