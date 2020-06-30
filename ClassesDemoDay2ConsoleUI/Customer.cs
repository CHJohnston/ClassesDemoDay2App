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
