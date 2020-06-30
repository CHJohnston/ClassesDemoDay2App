using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    class CheckingAccount
    {
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }

        //This is field
        private string _rountingNumber;
        public string RoutingNumber
        {
            get
            {
                return _rountingNumber;
            }
            set
            {
                if (value.Length == 9)
                {
                    _rountingNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Rounting Number");
                }
            }
        }           
        public Customer Owner { get; set; }
    }
}
