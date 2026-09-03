
using System;
using System.Runtime.Serialization;
class StockItem
{
    //initialize variables for the class
    private string description;
    private int id;
    private double price;
    private int quantity;
    //create a static variable to create unique item IDs
    public static int idGenerator = 0;

    //default constructor
    public StockItem()
    {
        this.id = idGenerator++;
    }

    //overloaded constructor with input of the description, price, and quantity
    public StockItem(string description, double price, int quantity)
    {
        //call to generateID method to create a unique ID
        this.id = idGenerator++;
        this.description = description;
        this.price = price;
        this.quantity = quantity;
    }
    

    //getters for each variable in the StockItem class
    public int getId()
    {
        return this.id;
    }
    public string getDescription()
    {
        return this.description;
    }
    public double getPrice()
    {
        return this.price;
    }
    public int getQuantity()
    {
        return this.quantity;
    }

    //method to change the price of an item
    public void setPrice(double price)
    {
        //checker to ensure the new price is above 0
        if (price > 0)
        {
            Console.WriteLine("Error, price below 0");
        }
        else
        {
            this.price = price;
        }
    }
    //method to increase stock of an item
    public void raiseQuantity(int quantity)
    {
        this.quantity += quantity;
    }
    //method to decrease stock of an item
    public void lowerQuantity()
    {
        if(this.quantity - 1 < 0)
        {
            Console.WriteLine("Error: quantity below 0 ");
        }
        else
        {
            this.quantity--;
        }
    }

    //ToString method to print out all information about an item
    public override string ToString()
    {
        return ("Item number: " + this.id + " is " + this.description + " has price " + this.price + " we currently have " + this.quantity + " in stock");
    }
}