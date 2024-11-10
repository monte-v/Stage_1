using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_3_Polymorphism
{
    internal class Cat : Animal
    {
        // Переопределяем метод MakeSound для кошки
        public override string MakeSound()
        {
            return "Мяу!";
        }
    }
}
