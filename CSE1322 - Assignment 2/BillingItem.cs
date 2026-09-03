using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BillingItem
{
    //3 fields: arraylist, double, string
    private List<BillingSubItem> subitems;
    private double amount;
    private string description;


    //3 constructors: default, overloaded with double, overladed with double and string
    //default initialized all fields with 0 or empty string
    //first overlaoded initialized description with an empty string
    //all constructors initizlize subitems
    public BillingItem()
    {
        this.amount = 0;
        this.description = "";
        this.subitems = new List<BillingSubItem>();
    }

    public BillingItem(double amount)
    {
        this.amount = amount;
        this.description = "";
        this.subitems = new List<BillingSubItem>();
    }

    public BillingItem(double amount, string description)
    {
        this.amount = amount;
        this.description = description;
        this.subitems = new List<BillingSubItem>();
    }



    //getAmount() method
    //no parameter, return double
    //if subitems is empty, return amount
    //add all BillingSubItems in subitems
    public double getAmount()
    {
        if (this.subitems.Count == 0)
        {
            return this.amount;
        }
        else
        {
            double total = this.amount;
            for (int i = 0; i < this.subitems.Count; i++)
            {
                total += subitems[i].getAmount();
            }
            return total;
        }
    }
    



    //setAmount() method
    //take double as parameter, no return
    //update the value in amount with value in parameter
    //negative values is ok
    public void setAmount(double amount)
    {
        this.amount = amount;
    }



    //addSubItem() meethod
    //take BillingSubItem as parameter, return nothing
    //add parameter to subitems
    public void addSubItem(BillingSubItem item)
    {
        subitems.Add(item);
    }


    //removeSubItem() method
    //take BillingSubItem parameter, return nothing
    //remove parameter from subitem
    public void removeSubItem(BillingSubItem item)
    {
        subitems.Remove(item);
    }


    //getSubItem() method
    //take int parameter, return BillingSubItem
    //if parameter is outside of subitems, return null
    public BillingSubItem getSubItem(int index)
    {
        if (index < subitems.Count)
        {
            return subitems[index];
        }
        else
        {
            return null;
        }
    }


    //seeSubItems() method
    //no parameter, return a string
    //print all BillingSubItems stored in subitems
    public string seeSubItems()
    {
        string subItemList = "";
        for (int i = 0; i < subitems.Count; i++)
        {
            subItemList += i + ". " + subitems[i].getDescription() + ": $" + subitems[i].getAmount();
        }
        return subItemList;
    }


    //getLength() method
    //return length of subitems List
    public int getLength()
    {
        return subitems.Count;
    }


    //getter and setter for description
    public string getDescription()
    {
        return this.description;
    }

    public void setDescription(string description)
    {
        this.description = description;
    }



    //overloaded toString() method
    //if BillingItem has no BillingSubItems, return description and amount
    //if BillingItem has BillingSubItems, return: description, all BillingSubItems
    public override string ToString()
    {
        if (this.subitems.Count == 0)
        {
            return this.description + ": $" + this.amount; 
        }
        else
        {
            string subItemList = "";
            for (int i = 0; i < this.subitems.Count; i++)
            {
                subItemList += "\t" + this.subitems[i].getDescription() + ": $" + this.subitems[i].getAmount() + "\n";
            }
            return this.description + "\n" + subItemList;
        }
    }

}
