using opp_1_BankAcoount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000); 

        Console.WriteLine($"Текущий баланс: {account.GetBalance()}");

        account.Deposit(500);
    }
}