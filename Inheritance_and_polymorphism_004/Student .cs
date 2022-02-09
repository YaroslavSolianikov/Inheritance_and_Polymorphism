using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_004
{
    class Student : Person
    {
        private string[] studyCourses;

        public string[] StudyCourses
        {
            get { return studyCourses; }
            set { studyCourses = value; }
        }
        public void DisplayStudyСourses()
        {
            if (studyCourses.Length > 3)
            {
                Console.WriteLine("Maximum number of courses must be 3!");
            }
            else
            {
                foreach (var item in studyCourses)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
