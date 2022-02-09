using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_002
{
    class Shape
    {
        public double Volume { get; set; }
        public virtual double GetVolume()
        {
            return Volume;
        }
    }
}
