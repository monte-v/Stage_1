using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_3_Polymorphism
{
    internal class Animal
    {
        // Метод, который будет переопределен в подклассах
        public virtual string MakeSound()
        {
            return "Некоторый звук";
        }
    }
}
