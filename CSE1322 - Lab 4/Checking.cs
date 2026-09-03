using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

class Checking : Account
{
    //constructor to set account balance
    public Checking(double accountBalance)
    {
        setAccountBalance(accountBalance);
        
    }


    //modified withdrawl method which checks for overdrafting
    //overdraft fee is $20, deduct that from account
    public override void withdraw(double amount)
    {
        if (getAccountBalance() - amount < 0)
        {
            Console.WriteLine("Charging an overdraft fee of $20 because account is below $0");
            base.withdraw(amount + 20);
        }
        else
        {
            base.withdraw(amount);
        }
    }
}