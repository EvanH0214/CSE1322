using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    //int attribute for account number
    //double attribute for account balance
    //static variable for setting account numbers
    private int accountNumber;
    private double accountBalance;
    private static int accountNumberGenerator = 10001;



    //constructor for an account object with a balance of 0
    //overloaded constructor with balance amount 
    public Account()
    {
        this.accountNumber = accountNumberGenerator++;
        this.accountBalance = 0;
    }
    public Account(double accountBalance)
    {
        this.accountNumber = accountNumberGenerator++;
        this.accountBalance = accountBalance;
    }



    //getter for account number
    //getter and setter for account balance
    public int getAccountNumber()
    {
        return this.accountNumber;
    }
    public double getAccountBalance()
    {
        return this.accountBalance;
    }
    public void setAccountBalance(double accountBalance)
    {
        this.accountBalance = accountBalance;
    }



    //withdrawl method that takes a doubple parameter and subtracts it from the balance
    public virtual void withdraw(double amount)
    {
        this.accountBalance -= amount;
    }


    //deposit method that takes a double parameter and adds it to the balance
    public virtual void deposit(double amount)
    {
        Console.WriteLine("Doing default deposit");
        this.accountBalance += amount;
    }
}

