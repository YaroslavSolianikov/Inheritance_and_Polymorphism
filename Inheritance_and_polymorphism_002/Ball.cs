using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_002
{
    class Ball : Shape
    {
        public double Radius { get; set; }
        public override double GetVolume()
        {
            Volume = Math.PI * Math.Pow(Radius, 3) * 4 / 3;
            return base.GetVolume();
        }
    }
}
