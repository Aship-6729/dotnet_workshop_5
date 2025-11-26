namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BankAccount account = new BankAccount(1001,5000);
            Console.WriteLine($"Account Number: {account.GetAccountNumber()}");

            account.Deposit(500);
            Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

            account.Withdraw(200);
            Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        }
    }
}
