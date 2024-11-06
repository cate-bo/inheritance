using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Dog
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
            Console.WriteLine("constructor in dog");
        }


        public virtual int GetBaseTax()
        {
            return 100;
        }

        public override string ToString()
        {
            return $"dog named {Name}";
        }
    }
}
