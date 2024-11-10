using solid_1_SRP;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Иван Иванов", "Разработчик", 50000);

        Console.WriteLine(employee.GetInfo());

        SalaryCalculator salaryCalculator = new SalaryCalculator();

        double bonus = 10000;
        double salary = salaryCalculator.CalculateSalary(employee, bonus);
        Console.WriteLine($"Зарплата с учетом бонуса: {salary}");

        double annualSalary = salaryCalculator.CalculateAnnualSalary(employee, bonus);
        Console.WriteLine($"Годовая зарплата с учетом бонуса: {annualSalary}");
    }
}