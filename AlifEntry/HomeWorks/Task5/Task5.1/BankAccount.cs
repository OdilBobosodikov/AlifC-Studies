using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5
{
    public class BankAccount
    {
        public string? Owner { get; private set; }
        public string? AccountNumber { get; private set; }
        public decimal Balance { get; set; }
        public string? AccountType { get; set; }

        public BankAccount(string owner, string accountNumber, decimal balance, string accountType)
        {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
        }

        public bool Deposit(decimal amount) 
        {
            if (amount < 0) 
            {
                Console.WriteLine("Error occurred, try again");
                return false;
            }
            Balance += amount;
            Console.WriteLine($"Deposited to balance of user {Owner} {amount}$ so total is {Balance}$");
            return true;
        }

        public bool Withdraw(decimal amount) 
        {
            if (amount > Balance || amount < 0) 
            {
                Console.WriteLine("Error occurred, try again");
                return false;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawed from balance of user {Owner} {amount}$ so total is {Balance}$");
            return true;
        }

        public void TransferTo(BankAccount target, decimal amount) 
        {
            if (!Withdraw(amount))
            {
                Console.WriteLine("Error occurred, try again");
                return;
            }
            target.Deposit(amount);
        }

        public string PrintStatement() 
        {
            return $"Owner: {Owner}\nAccount number:{AccountNumber}\nBalance: {Balance}\nAccount type: {AccountType}";
        }
    }
}
