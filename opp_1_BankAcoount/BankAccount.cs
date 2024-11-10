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

        // Метод для пополнения счета
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма пополнения должна быть положительной.");
            }
            balance += amount;
            Console.WriteLine($"Вы пополнили счет на {amount}. Новый баланс: {balance}");
        }

        // Метод для снятия средств со счета
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма снятия должна быть положительной.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Недостаточно средств на счете.");
            }
            balance -= amount;
            Console.WriteLine($"Вы сняли {amount}. Новый баланс: {balance}");
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
