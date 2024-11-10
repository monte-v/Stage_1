using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_5_DIP
{
    internal class ConsoleLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Лог в консоль: {message}");
        }
    }
}
