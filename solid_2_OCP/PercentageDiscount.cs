using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_2_OCP
{
    internal class PercentageDiscount : Discount
    {
        public double Percentage { get; set; } // Процент скидки

        public PercentageDiscount(double percentage)
        {
            Percentage = percentage;
        }

        // Реализация метода Calculate для процентной скидки
        public override double Calculate(double originalPrice)
        {
            return originalPrice - (originalPrice * (Percentage / 100));
        }
    }
}
