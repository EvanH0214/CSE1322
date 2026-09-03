using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        //create checking and savings account
        Checking checking = new Checking(0);
        Savings savings = new Savings(0);



        //while loop to prompt user until they quit
        bool cont = true;
        while (cont)
        {
            //print out all options to user
            Console.WriteLine("1. Withdraw from Checking");
            Console.WriteLine("2. Withdraw from Savings");
            Console.WriteLine("3. Deposit to Checking");
            Console.WriteLine("4. Deposit to Savings");
            Console.WriteLine("5. Balance of Checking");
            Console.WriteLine("6. Balance of Savings");
            Console.WriteLine("7. Award Interest to Savings now");
            Console.WriteLine("8. Quit");

            int input = Int32.Parse(Console.ReadLine());

            //option 1 to Withdraw from Checking
            if (input == 1)
            {
                Console.WriteLine("How much would you like to withdraw from Checking?");
                checking.withdraw(double.Parse(Console.ReadLine()));
            }



            //option 2 to Withdrawl from Savings
            if (input == 2)
            {
                Console.WriteLine("How much would you like to withdraw from Savings?");
                savings.withdraw(double.Parse(Console.ReadLine()));
            }


            //option 3 to Deposit to Checkings
            if (input == 3)
            {
                Console.WriteLine("How much would you like to deposit into Checking?");
                checking.deposit(double.Parse(Console.ReadLine()));
            }


            //option 4 to Deposit to Savings
            if (input == 4)
            {
                Console.WriteLine("How much would you like to deposit into Savings?");
                savings.deposit(double.Parse(Console.ReadLine()));
            }


            //option 5 to check Balance of Checking
            if (input == 5)
            {
                Console.WriteLine("Your balance for checking " + checking.getAccountNumber() + " is " + checking.getAccountBalance());
            }


            //option 6 to check Balance of Savings
            if (input == 6)
            {
                Console.WriteLine("Your balance for savings " + savings.getAccountNumber() + " is " + savings.getAccountBalance());
            }


            //option 7 to Award Interest to Savings
            if (input == 7)
            {
                savings.addInterest();
            }


            //option 8 to quit
            if (input == 8)
            {
                cont = false;
            }
        }
    }
}