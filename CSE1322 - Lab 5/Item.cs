using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Item
{
    //private string attribute called title
    private string title;


    //getter and setter for title attribute
    public string getTitle()
    {
        return this.title;
    }

    public void setTitle(string title)
    {
        this.title = title;
    }

    //constructor with no parameters
    public Item()
    {
        this.title = "";
    }


    //overloaded constructor which takes a string parameter
    public Item(string title)
    {
        this.title = title;
    }


    //getListing() abstract method that returns a string 
    public abstract string getListing();


    //overrided toString to return the title
    public override string ToString()
    {
        return this.title;
    }
} 