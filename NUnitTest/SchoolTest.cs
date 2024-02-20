using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class SchoolTest
    {

        Student s = new Student();

        Subject sub = new Subject();
        Teacher ts = new Teacher();

        [TestCase("Ravi", ExpectedResult = true)]
        [TestCase("Sam", ExpectedResult = true)]
        [TestCase("Rani", ExpectedResult = false)]
        [TestCase("Naina", ExpectedResult = false)]
        [TestCase("Sameer", ExpectedResult = true)]
        public bool IsName(string search)
        {
            return s.Search(search);
        }

        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("History", ExpectedResult = true)]
        [TestCase("Geometry", ExpectedResult = true)]
        [TestCase("English", ExpectedResult = false)]
        public bool IsSubject(string subj)
        {
            return sub.Search(subj);
        }

        [TestCase("Shyam", ExpectedResult = true)]
        [TestCase("Shekhar", ExpectedResult = true)]
        [TestCase("Rahul", ExpectedResult = true)]
        [TestCase("Riya", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }

    }
}
