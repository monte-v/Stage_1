using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_1_generalized_class
{
    internal class Pair<T, U>
    {
        private T _first;
        private U _second;

        public Pair(T first, U second)
        {
            _first = first;
            _second = second;
        }

        // Свойство для получения и установки первого значения
        public T First
        {
            get { return _first; }
            set { _first = value; }
        }

        // Свойство для получения и установки второго значения
        public U Second
        {
            get { return _second; }
            set { _second = value; }
        }

        public override string ToString()
        {
            return $"Pair: ({First}, {Second})";
        }
    }
}
