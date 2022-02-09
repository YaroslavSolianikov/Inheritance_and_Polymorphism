using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polymorphism_004
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { "MAth", "OOP", "Eng" };
            string[] courses2 = { "SQL", "Prog", "Ecomomy" };
            Student student1 = new Student() { Name = "John", Surname = "Anderson", BirthYear = 2001, StudyCourses = courses };
            Student student2 = new Student() { Name = "Mike", Surname = "Brown", BirthYear = 2002, StudyCourses = courses };
            Student student3 = new Student() { Name = "David", Surname = "Lewis", BirthYear = 2000, StudyCourses = courses };
            Student student4 = new Student() { Name = "Jacks", Surname = "Martin", BirthYear = 2003, StudyCourses = courses2 };
            Student student5 = new Student() { Name = "Rock", Surname = "Miller", BirthYear = 1999, StudyCourses = courses2 };

            Teacher teacher1 = new Teacher() { Name = "Kevin", Surname = "Moore", BirthYear = 1986 };
            Teacher teacher2 = new Teacher() { Name = "Thomas", Surname = "Robinson", BirthYear = 1979 };
            teacher1.Students = new Student[5] { student1, student2, student3, student4, student5 };

            PeopleInfo peopleInfo = new PeopleInfo();
            peopleInfo.People = new Person[] { student1, student2, student3, student4, student5, teacher1, teacher2 };
            peopleInfo.Info();
            Console.ReadKey();
        }
    }
}
