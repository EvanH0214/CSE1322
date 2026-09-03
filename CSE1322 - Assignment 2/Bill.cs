using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bill
{
    //4 fields: arraylist, static int, int, static double
    private List<BillingItem> items;
    private static int nextID = 0;
    private int id;
    private static double taxPercentage = 0;



    //default constructor
    public Bill()
    {
        items = new List<BillingItem>();
        id = nextID++;
    }




    //setTax() method
    //double as parameter to update tax percentage and return nothing
    //parameter must be >= 0
    public void setTax(double tax)
    {
        if(tax >= 0)
        {
            taxPercentage = tax;
        }
    }

    //getter for taxPercentage
    //static
    public static double getTaxPercentage()
    {
        return taxPercentage;
    }


    //addItem() method
    //take in BillingItem as parameter and return nothing
    //add parameter to items arraylist
    public void addItem(BillingItem item)
    {
        items.Add(item);
    }


    //removeItem() method
    //take in the item which will be removed return nothing
    //remove parameter from items arraylist
    public void removeItem(BillingItem item)
    {
        items.Remove(item);
    }


    //getItem() method
    //take in an int as parameter and rethrn a BillingItem
    //parameter is the index of a BillingItem in items
    //return null if item is not found
    public BillingItem getItem(int index)
    {
        if (index < items.Count)
        {
            return items[index];
        }
        else
        {
            return null;
        }
    }


    //seeItems() method
    //no parameter, return a string of all BillingItems in items
    //return empty string if items is empty
    //return in format "Position.Item-Description: $item-amount"
    public string seeItems()
    {
        string itemsList = "";
        if (items.Count == 0)
        {
            return itemsList;
        }
        for (int i = 0; i < items.Count; i++)
        {
            itemsList += i + ". " + items[i].getDescription() + ": $" + items[i].getAmount() + "\n"; ;
        }
        return itemsList;
    }


    //calculateSubTotal() method
    //no parameter return a double
    //add amount of BillingItems in items and return the sum
    public double calculateSubTotal()
    {
        double total = 0;
        for (int i = 0; i < items.Count; i++)
        {
            total += items[i].getAmount();
        }
        return total;
    }


    //calculateTotal() method
    //no parameter return a double
    //add amount of BillingItems in items and multiply by tax percentage
    public double calculateTotal()
    {
        double total = calculateSubTotal() + (calculateSubTotal() * (taxPercentage / 100));
        return total;
    }

    //getLength() method
    //return the length of the items List
    public int getLength()
    {
        return this.items.Count;
    }


    //overrided toString() method
    //contain Bill's id, every BillingItem in Bill, subtotal, total
    public override string ToString()
    {
        string billString = "";
        billString += "=================================== \n# " + this.id + "\n";
        for (int i = 0; i < items.Count; i++)
        {
            billString += items[i].ToString() + "\n";
        }
        billString += "Subtotal: " + calculateSubTotal() + "\n" + "Total + tax: " + calculateTotal() + "\n=============================";
        return billString;
    }
}