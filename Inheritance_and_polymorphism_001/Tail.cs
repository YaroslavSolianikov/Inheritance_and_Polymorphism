using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_001
{
    class Tail
    {
        public int TailLenght { get; set; }
        public string Type { get; set; }
        public Tail(int TailLenght, string Type)
        {
            this.TailLenght = TailLenght;
            this.Type = Type;
        }
    }
}

