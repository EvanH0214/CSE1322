using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

abstract class Percipitation : WeatherEvent
{
    //private double attribute called rateOfFall
    private double rateOfFall;


    //getter and setter for rateOfFall
    //rateOfFall cannot be below 0
    public double getRateOfFall()
    {
        return this.rateOfFall;
    }
    public void setRateOfFall(double rateOfFall)
    {
        if (rateOfFall >= 0)
        {
            this.rateOfFall = rateOfFall;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    //overloaded constructor which takes a string, bool, and double
    //location and activity must be passed to the super class constructor
    public Percipitation(string location, bool active, double rateOfFall) : base(location, active)
    {
        this.rateOfFall = rateOfFall;
    }


    //overriden ToString() method
    //add to the base ToString()
    //light = less than .5
    //medium = between .5 and 1.5
    //heavy = above 1.5
    //base.ToString() + "\nRate of Fall: " + rateOfFall + "in/h " + (light/medium/heavy)
    public override string ToString()
    {
        string rainfall = "";
        if (this.rateOfFall < .5)
        {
            rainfall = "Light";
        }
        else if (this.rateOfFall >= .5 && this.rateOfFall <= 1.5)
        {
            rainfall = "Medium";
        }
        else
        {
            rainfall = "Heavy";
        }


        string percipitation = base.ToString() + "\nRate of Fall: " + this.rateOfFall + " in/h (" + rainfall + ")";
        return percipitation;
    }
}
