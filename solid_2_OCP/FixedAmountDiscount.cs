using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_2_OCP
{
    internal class FixedAmountDiscount : Discount 
    {
        public double Amount { get; set; } // Фиксированная сумма скидки

        // Конструктор
        public FixedAmountDiscount(double amount)
        {
            Amount = amount;
        }

        // Реализация метода Calculate для фиксированной скидки
        public override double Calculate(double originalPrice)
        {
            return originalPrice - Amount;
        }
    }
}
