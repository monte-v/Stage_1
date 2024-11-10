using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_3_LSP
{
    abstract class Bird
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
    }
}
