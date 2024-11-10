using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_1_BankAcoount
{
    internal class BankAccount
    {
        // Поле для хранения баланса (инкапсуляция)
        private decimal balance;

        // Конструктор для инициализации счета с начальным балансом
        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Начальный баланс не может быть отрицательным.");
            }
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
