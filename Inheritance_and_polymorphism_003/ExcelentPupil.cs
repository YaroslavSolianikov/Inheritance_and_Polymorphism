using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_003
{
    class ExcelentPupil : Pupil
    {
        public override string Studying { get; set; }
        public override string Relaxing { get; set; }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Excelent pupil " + Studying);
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Excelent pupil " + Studying);
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Excelent pupil " + Studying);
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Excelent pupil " + Relaxing);
        }
    }
}
