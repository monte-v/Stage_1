using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_5_DIP
{
    internal class FileLogger: ILogger
    {
        public void Log(string message)
        {
            // просто имитация
            Console.WriteLine($"Лог в файл: {message}");
        }
    }
}
