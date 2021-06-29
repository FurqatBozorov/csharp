using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Furqat", 20000);
            Console.WriteLine($"This {account.Number} account was created for {account.Owner} with {account.Balance} initial balance");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(100, DateTime.Now, "Friend paid me back");
            account.MakeWithdrawal(250, DateTime.Now, "tax");
            
            Console.WriteLine(account.GetAccountHistory());





        }
    }
}
