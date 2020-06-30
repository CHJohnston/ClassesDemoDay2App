using System;

namespace ClassesDemoDay2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {   //Instancinating a Customer = Creating a variable of the Customer Data Type
            Customer c = new Customer();

            Console.WriteLine("Enter your First Name");
            c.FirstName= Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            c.LastName = Console.ReadLine();

            Console.WriteLine($"Hello {c.FirstName}  {c.LastName} Please Enter your Age");
            c.Age = int.Parse(Console.ReadLine());

            if (c.Age < 18)
            {
                Console.WriteLine("Sorry you're too young for a Banking Account.");
            }
            else 
            {   //Instancinating a Checking Account  
                CheckingAccount cCheckingAccount = new CheckingAccount();
                //Setting Properties for the Checking Account
                cCheckingAccount.RoutingNumber = "123456789";
                Console.WriteLine($"Your Routing Number is {cCheckingAccount.RoutingNumber}");
                cCheckingAccount.AccountNumber = "2541234";
                Console.WriteLine($"Your Checking Account Number is {cCheckingAccount.AccountNumber}");

                //setting the owner property to the instance of the customer we created
                cCheckingAccount.Owner = c;
                Console.WriteLine($"The Owner of the Account is {cCheckingAccount.Owner.FirstName} {cCheckingAccount.Owner.LastName} ");                
            }            
        }
    }
}
