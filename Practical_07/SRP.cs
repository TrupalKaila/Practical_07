using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
    //BankAccount has only task for deposit and withdraw money - This is a single responsibility of bankaccount class can perform
    public class BankAccount
    {
        //Created the properties to set and get values
        public long AccountNumber { get; set; }
        public double Balance { get; set; }
        //Created a list of string to store the transaction which is performed and then can be used in printing the statement
        public List<string> Transactions = new List<string>();
        //Parameterized constructor to initialize account number in properties created above
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
    //StatePrinter has only task to print the statement of transactions
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
