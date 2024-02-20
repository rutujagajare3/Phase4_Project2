using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Subject
    {
        private string _subname;

        public string Name
        {
            get { return _subname; }
            set { _subname = value; }
        }

        private string _subCode;

        public string SubCode
        {
            get { return _subCode; }
            set { _subCode = value; }
        }

        //public Subject(string n, string c)
        //{
        //	Name = n;
        //	SubCode = c;

        //}

        public bool Search(string s)
        {
            List<Subject> sublist = new List<Subject>();

            sublist.Add(new Subject { Name = "History", SubCode = "400" });
            sublist.Add(new Subject { Name = "Geometry", SubCode = "401" });
            sublist.Add(new Subject { Name = "Maths", SubCode = "402" });



            var isfound = sublist.Find(d => d.Name == s);
            return isfound != null;
        }

    }
}
