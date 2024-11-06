using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class Student : Person
    {

        public string Class { get; set; }

        public Student(string name, string email, DateOnly birthdate, string _class) : base(name, email, birthdate)
        {
            Class = _class;
        }

        public override string ToString()
        {
            return $"Student: {base.ToString()}, class: {Class}";
        }


    }
}
