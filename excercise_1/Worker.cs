using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class Worker : Person
    {
        

        public string FunctionDescritpion { get; set; }


        public Worker(string name, string email, DateOnly birthdate, string functionDescription) : base(name, email, birthdate)
        {
            FunctionDescritpion = functionDescription;
        }

        public override string ToString()
        {
            return $"Worker: {base.ToString()}, functiondescription: {FunctionDescritpion}";
        }
    }
}
