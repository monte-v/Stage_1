using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_1_SRP
{
    internal class Employee
    {
        public string Name { get; set; }         
        public string Position { get; set; }      
        public double BaseSalary { get; set; }    

        public Employee(string name, string position, double baseSalary)
        {
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }

        // Метод для получения информации о сотруднике
        public string GetInfo()
        {
            return $"Имя: {Name}, Должность: {Position}, Базовая зарплата: {BaseSalary}";
        }
    }
}
