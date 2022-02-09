using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_003
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            excelentPupil.Studying = "excelent";
            excelentPupil.Relaxing = "read books";

            BadPupil badPupil = new BadPupil();
            badPupil.Studying = "bad";
            badPupil.Relaxing = "play football";

            GoodPupil goodPupil = new GoodPupil();
            goodPupil.Studying = "good";
            goodPupil.Relaxing = "play computer games";
            ClassRoom classRoom = new ClassRoom(excelentPupil, badPupil, goodPupil);

            classRoom.StudyInfo();
            classRoom.ReadInfo();
            classRoom.WriteInfo();
            classRoom.RelaxInfo();

            Console.ReadKey();
        }
    }
}
