using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_3_Polymorphism
{
    internal class Dog : Animal
    {
        // Переопределяем метод MakeSound для собаки
        public override string MakeSound()
        {
            return "Гав!";
        }
    }
}
