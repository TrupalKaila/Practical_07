using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
    public class BankAccount
    {
        public long AccountNumber { get; set; }
        public double Balance { get; set; }
        public List<string> Transactions = new List<string>();

        public BankAccount(long accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"{amount} is Deposited. New Balance: {Balance}");
        }
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Transactions.Add($"{amount} is Withdrawn. New Balance : {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
    public class StatementPrinter
    {
        public void Print(BankAccount bankAccount)
        {
            Console.WriteLine($"Statement for Account: {bankAccount.AccountNumber}");
            foreach (string transaction in bankAccount.Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
