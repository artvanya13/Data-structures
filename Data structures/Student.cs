using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structures
{
    class Student
    {
        private string name;
        private string grade;
        public Student next;
        public Student previous;
        public Student(string n, string g)
        {
            name = n;
            grade = g;
        }

        public string getname()
        {
            return name;
        }

        public void setname(string name)
        {
            string n = name;
        }

        public string getgrade()
        {
            return grade;
        }

        public void setgrade(string grade)
        {
            string g = grade;
        }

    }
}
