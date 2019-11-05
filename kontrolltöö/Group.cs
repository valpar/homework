using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firsttest
{
    class Group
    {
        public string Name { get; set; }

        public List<Student> ListOfStudents = new List<Student>();

        public Group(string GroupsName)
        {
            Name = GroupsName;
        }

        public void AddNewStudent(string studentsFName, string studentsLName, int studentsPCode)
        {
            Student NewStudent = new Student(studentsFName, studentsLName, studentsPCode, true);
            ListOfStudents.Add(NewStudent);
        }

        public void RemoveStudent()
        {

        }

        public void ListStudents()
        {
            foreach (Student s in ListOfStudents)
            {
                Console.WriteLine(s);
            }
        }



    }
}
