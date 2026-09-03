using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rain : Percipitation
{
    //private double attribute called dropSize
    private double dropSize;


    //getter and setter for dropSize
    //dropSize cannot be below .02
    public double getDropSize()
    {
        return this.dropSize;
    }
    public void setDropSize()
    {
        if (this.dropSize >= .02)
        {
            this.dropSize = dropSize;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    //overloaded constructor which takes the location, active, rateOfFall, dropSize
    //call base for location, active, and rateOfFall
    public Rain(string location, bool active, double rateOfFall, double dropSize) : base(location, active, rateOfFall)
    {
        this.dropSize = dropSize;
    }


    //overrided ToString() method which calls the base ToString()
    public override string ToString()
    {
        string size = "";
        if (this.dropSize < .066)
        {
            size = "Small";
        }
        else if (this.dropSize >= .066 && this.dropSize <= .112)
        {
            size = "Medium";
        }
        else
        {
            size = "Large";
        }
        string rain = base.ToString() + "\nDrop size: " + this.dropSize + " (" + size + ")";
        return rain;
    }
}