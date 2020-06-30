using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class CheckingAccount
    {
        //Add Logic to require PIN to Access Balance
        public decimal Balance { get; set; }

        public string AccountNumber { get; set; }

        //This is a field with custom get set logic
        private string _routingNumber;
        public string RoutingNumber
        {
            get
            {
                return _routingNumber;
            }
            set
            {
                if (value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Routing Number");
                }
            }
        }           
        public Customer Owner { get; set; }

        public void PrintBalance()
        {
            Console.WriteLine($"Your Current Balance is {Balance}");
        }

    }
}
