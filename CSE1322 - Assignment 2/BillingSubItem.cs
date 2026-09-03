using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BillingSubItem
{
    //2 fields: double, string
    private double amount;
    private string description;


    //1 overloaded constructor
    //constructor takes double and string as parameters
    public BillingSubItem(double amount, string description)
    {
        this.amount = amount;
        this.description = description;
    }


    //getters and setters for each field
    public double getAmount()
    {
        return this.amount;
    }
    public string getDescription()
    {
        return this.description;
    }

    public void setAmount(double amount)
    {
        this.amount = amount;
    }
    public void setDescription(string description)
    {
        this.description = description;
    }


    //overloaded toString() method
    //return both fileds in BillingSubItem
    //"Description: $Amount"
    public override string ToString()
    {
        return "SubItem " + this.description + " $" + this.amount;
    }
}
