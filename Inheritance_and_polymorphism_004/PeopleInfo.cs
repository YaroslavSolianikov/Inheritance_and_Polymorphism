using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_004
{
    class PeopleInfo
    {
        private Person[] people;
        public Person[] People
        {
            get { return people; }
            set { people = value; }
        }
        public void Info()
        {
            Person person = new Student();
            var res = from p in people
                      orderby p.BirthYear descending
                      select p;
            foreach (Person p in res)
            {
                person = p;
                Student student1 = person as Student;
                if (person == student1)
                {
                    student1.DisplayStudyСourses();
                }
                Console.WriteLine($"{p.Name} - {p.Surname} - {p.BirthYear}");
            }
        }
    }
}
