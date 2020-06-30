using System;

namespace ClassesDemoDay2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {   //Instancinating a Customer = Creating a variable of the Customer Data Type
            Customer c = new Customer();

            Console.Write("Enter your First Name ");
            c.FirstName= Console.ReadLine();

            Console.Write("Enter your Last Name ");
            c.LastName = Console.ReadLine();

            Console.Write($"Hello {c.FirstName}  {c.LastName} Please Enter your Age ");
            c.Age = int.Parse(Console.ReadLine());

            if (c.Age > 18)
            {//Instancinating a Checking Account  
                CheckingAccount cCheckingAccount = new CheckingAccount();
                //Setting Properties for the Checking Account
                cCheckingAccount.RoutingNumber = "123456789";
                Console.WriteLine($"Your Routing Number is {cCheckingAccount.RoutingNumber}");
                cCheckingAccount.AccountNumber = "2541234";
                Console.WriteLine($"Your Checking Account Number is {cCheckingAccount.AccountNumber}");

                //setting the owner property to the instance of the customer we created
                cCheckingAccount.Owner = c;
                c.UserCheckingAccount = cCheckingAccount;
                Console.WriteLine($"The Owner of the Account is {cCheckingAccount.Owner.FirstName} {cCheckingAccount.Owner.LastName} ");
            }
            else
            {
                Console.WriteLine("Sorry you're too young for a Banking Account.");
                return;
            }

            Console.WriteLine();
            Console.Write("If you want to deposit or withdraw money from your Checking Account? Enter (deposit or withdraw) ");
            string userResponse = Console.ReadLine();            
            decimal amount = 0;
            switch (userResponse)
            {
                case "deposit":
                    Console.WriteLine("Please enter the Deposit Amount ");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Deposit(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;
                case "withdraw":
                    Console.WriteLine("Please enter the Withdraw Amount ");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Withdraw(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;
            }

            Console.WriteLine();
            Console.Write("Would you like to open a Savings Account? (Y/N)");
            string setupNewSavings = Console.ReadLine();
            if (setupNewSavings == "y" || setupNewSavings=="Y") 
            {
                //Instancinating a Savings Account  
                SavingsAccount cSavingsAccount = new SavingsAccount();

                //Setting Properties for the Savings Account           
                cSavingsAccount.AccountNumber = "123454";
                Console.WriteLine($"Your Savings Account Number is {cSavingsAccount.AccountNumber}");

                Console.WriteLine("Enter the amount for your Initial Deposit - NOTE A minimum deposit of $100 is required");
                cSavingsAccount.InitialDeposit = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Your Deposit Amount is {cSavingsAccount.InitialDeposit}");

                //setting the owner property to the instance of the customer we created
                cSavingsAccount.Owner = c;
                c.UserSavingsAccount = cSavingsAccount;
                Console.WriteLine($"The Owner of the Savings Account is {cSavingsAccount.Owner.FirstName} {cSavingsAccount.Owner.LastName} ");
            }

            Console.WriteLine();
            Console.Write("Would you like a Credit Card? (Y/N)");
            string setupNewCreditCard = Console.ReadLine();
            if (setupNewCreditCard == "y" || setupNewCreditCard == "Y")
            {
                //Instancinating a Credit Card 
                CreditCard cCreditCard = new CreditCard();
                Console.Write("Enter the amount for your Credit Limit ");
                cCreditCard.CreditLimit = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Your Credit Limit is {cCreditCard.CreditLimit}");

                //For some reason the following caused an error -- Needs to be debugged
                //Console.WriteLine($"The Owner of the Account is {cCreditCard.Owner.FirstName} {cCreditCard.Owner.LastName} ");
            }
        }                
    }
}

