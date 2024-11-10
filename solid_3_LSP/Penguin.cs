using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace solid_3_LSP
{
    internal class Penguin : Bird
    {
        public Penguin(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (пингвин) издает звук: Хитрый звук пингвина!");
        }
    }
}
