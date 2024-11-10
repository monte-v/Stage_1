using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_2_OCP
{
    abstract class Discount
    {
        // Абстрактный метод для расчета скидки
        public abstract double Calculate(double originalPrice);
    }
}
