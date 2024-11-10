using opp_1_BankAcoount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000); 

        Console.WriteLine($"Текущий баланс: {account.GetBalance()}");

        account.Deposit(500);

        account.Withdraw(200);

        try
        {
            account.Withdraw(2000); 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Текущий баланс: {account.GetBalance()}");
    }
}