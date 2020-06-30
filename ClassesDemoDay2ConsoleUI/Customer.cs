using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class Customer
    {   //This is the Customer Class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }
        public CheckingAccount UserCheckingAccount { get; set; }
        public SavingsAccount UserSavingsAccount { get; set; }
        public CreditCard UserCreditCard { get; set; }

        public void Deposit(decimal amount)
        {
            UserCheckingAccount.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            UserCheckingAccount.Balance -= amount;
        }
          
        //Default Ctor    
        public Customer()
        {
        }

        public Customer(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
    }
}
