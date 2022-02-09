﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_003
{
    class BadPupil : Pupil
    {
        public override string Studying { get; set; }
        public override string Relaxing { get; set; }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Bad pupil " + Studying);
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Bad pupil " + Studying);
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Bad pupil " + Studying);
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Bad pupil " + Relaxing);
        }
    }
}
