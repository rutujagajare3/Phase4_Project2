﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _class;

        public int Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private char _section;

        public char Section
        {
            get { return _section; }
            set { _section = value; }
        }

        //public Student(string n, int c, char s)
        //{
        //	Name = n;
        //	Class = c;
        //	Section = s;

        //}

        public bool Search(string s)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Sam", Class = 10, Section = 'A' });
            students.Add(new Student { Name = "Ravi", Class = 9, Section = 'B' });
            students.Add(new Student { Name = "Sameer", Class = 8, Section = 'C' });

            var isfound = students.Find(d => d.Name == s);
            return isfound != null;
        }
    }
}
