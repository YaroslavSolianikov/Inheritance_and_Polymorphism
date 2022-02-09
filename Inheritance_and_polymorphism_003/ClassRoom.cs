using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_003
{
    class ClassRoom
    {
        Pupil[] Pupils;
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            Pupils = new Pupil[4] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            Pupils = new Pupil[3] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            Pupils = new Pupil[2] { p1, p2 };
        }
        public void StudyInfo()
        {
            foreach (var item in Pupils)
            {
                item.Study();
            }
        }
        public void ReadInfo()
        {
            foreach (var item in Pupils)
            {
                item.Read();
            }
        }
        public void WriteInfo()
        {
            foreach (var item in Pupils)
            {
                item.Write();
            }
        }
        public void RelaxInfo()
        {
            foreach (var item in Pupils)
            {
                item.Relax();
            }
        }

    }
}
