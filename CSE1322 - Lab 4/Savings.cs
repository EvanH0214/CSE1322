using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Savings : Account
{
    //static attribute to track number of deposits
    private static int depositCounter = 0;


    //constructor to set account balance
    public Savings(double accountBalance)
    {
        setAccountBalance(accountBalance);
    }



    //modified withdrawl method to add a minimum balance
    //if account balance drops below $500, charge $10 and deduct from balance
    public override void withdraw(double amount)
    {
        if (getAccountBalance() - amount < 500)
        {
            Console.WriteLine("Charging a fee of $10 because you are below $500");
            base.withdraw(amount + 10);
        }
        else
        {
            base.withdraw(amount);
        }
    }


    //modified deposit method to charge if user does more than 5 deposits
    //print out the number of deposits the user has preformed
    //charge $10 for every deposit past 5
    public override void deposit(double amount)
    {
        Console.WriteLine("This is deposit " + ++depositCounter + " to this account");
        if (depositCounter > 5)
        {
            Console.WriteLine("Charging a fee of $10");
            base.deposit(amount - 10);
        }
        else
        {
            base.deposit(amount);
        }
    }



    //addInterest() method that adds 1.5% interest to the account
    //print out the amount of interest earned by the customer
    //add the interest to the customer's balance
    public void addInterest()
    {
        double interestEarned = getAccountBalance() * .015;
        Console.WriteLine("Customer earned " + interestEarned + " in interest");
        base.deposit(interestEarned);
    }
}
