using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace solid_3_LSP
{
    internal class Eagle : Bird, IFlyable
    {
        public Eagle(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (орел) издает звук: Крик орла!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} летит высоко в небе.");
        }
    }
}
