using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_002
{
    class Box
    {
        public double DrawerVolume { get; set; }
        public bool Add(double sum)
        {
            if (sum <= DrawerVolume)
            {
                return true;
            }
            else
                return false;
        }
        public double VolumeShapes(Shape shape)
        {
            return shape.GetVolume();
        }
    }
}
