using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class Teacher : Person
    {
        

        public string Subject { get; set; }


        public Teacher(string name, string email, DateOnly birthdate, string subject) : base(name, email, birthdate)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return $"Teacher: {base.ToString()}, subject: {Subject}";
        }
    }
}
