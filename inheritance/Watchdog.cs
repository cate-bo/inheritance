using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Watchdog : Dog
    {
        public string Workplace { get; set; }
        public Watchdog(string name, string workplace) : base(name)
        {
            Console.WriteLine("constructor in watchdog");
            Workplace = workplace;
        }

        public override int GetBaseTax()
        {
            return base.GetBaseTax() / 2;
        }

        public override string ToString()
        {
            return $"watchdog with da name {Name}";
        }
    }
}
