using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateOnly Birthdate { get; set; }

        public Person(string name, string email, DateOnly birthdate)
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
        } 

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Birthdate: {Birthdate}";
        }
    }
}
