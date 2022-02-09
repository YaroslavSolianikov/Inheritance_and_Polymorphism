using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_002
{
    class Pyramid : Shape
    {
        public double Square { get; set; }
        public double Height { get; set; }
        public override double GetVolume()
        {
            Volume = Square * Height / 3;
            return base.GetVolume();
        }
    }
}
