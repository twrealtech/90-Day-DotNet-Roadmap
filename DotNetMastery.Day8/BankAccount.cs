using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMastery.Day8
{
    internal class BankAccount
    {
        public string AccountHolder {  get; set; }
        public string AccountNumber {  get; set; }
        private decimal Balance {  get; set; }

        public BankAccount(string accountHolder, string accountNumber, decimal balance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount!");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited: {amount} | New balance : {Balance}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid Withdraw amount!");
                return;
            }
            if (amount > Balance) 
            { 
            Console.WriteLine("Insufficient Balance!");
                return;
            
            }
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount} | New balance : {Balance}");
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Account Holder: {AccountHolder} | Account Number: {AccountNumber} | Balance: {Balance}");
        }

    }
}
