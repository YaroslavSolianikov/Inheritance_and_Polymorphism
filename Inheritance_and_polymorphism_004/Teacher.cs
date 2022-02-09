using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_004
{
    class Teacher : Person
    {
        private Student[] students;
        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }
    }
}
