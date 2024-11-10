using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_4_ISP
{
    internal class LaserPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печать документа: {document} с помощью лазерного принтера.");
        }
    }
}
