using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firsttest
{
    class Student
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        public int PersonalCode { get; set; }

        bool IsStudying { get; set; }

        public Student(string firstName, string lastName, int personalCode, bool isStudying)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalCode = personalCode;
            IsStudying = isStudying;

        }

        public override string ToString()
        {
            return $"Student's First Name: {FirstName}\nStudent's Last Name: {LastName}\nStudent's PersonalCode: {PersonalCode}\n{IsStudying}\n\n ";
        }


    }
}
