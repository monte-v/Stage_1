using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_1_SRP
{
    internal class SalaryCalculator
    {
        // Метод для расчета зарплаты с учетом бонусов
        public double CalculateSalary(Employee employee, double bonus)
        {
            return employee.BaseSalary + bonus;
        }

        // Метод для расчета годовой зарплаты
        public double CalculateAnnualSalary(Employee employee, double bonus)
        {
            return (employee.BaseSalary + bonus) * 12; 
        }
    }
}
