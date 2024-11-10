using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_4_ISP
{
    internal class AllInOnePrinter : IMultifunctionDevice
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печать документа: {document} с помощью многофункционального устройства.");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Сканирование документа: {document} с помощью многофункционального устройства.");
        }
    }
}
