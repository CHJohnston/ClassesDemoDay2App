using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class SavingsAccount
    {
        public string AccountNumber { get; set; }

        private decimal _initialDeposit;
        public decimal InitialDeposit
        {
            get
            {
                return _initialDeposit;
            }
            set
            {
                if (value >= 100)
                {
                    _initialDeposit = value;
                }
                else
                {
                    Console.WriteLine("Minimum Deposit Amount is Required.");
                }
            }
        }

        public Customer Owner { get; set; }
    }
}
