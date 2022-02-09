using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_003
{
    class Pupil
    {
        public virtual string Studying { get; set; }
        public virtual string Relaxing { get; set; }
        public virtual void Study()
        {
            Console.WriteLine("Study:");
        }
        public virtual void Read()
        {
            Console.WriteLine("Read:");
        }
        public virtual void Write()
        {
            Console.WriteLine("Write:");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Relax:");
        }
    }
}
