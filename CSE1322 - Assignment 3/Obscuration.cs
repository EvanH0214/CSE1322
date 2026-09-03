using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Obscuration : WeatherEvent
{
    //private int attribute called visibility
    private int visibility;


    //getter and setter for visiblity
    //visibility cannot be less than 0
    public int getVisibility()
    {
        return this.visibility;
    }
    public virtual void setVisibility(int visibility)
    {
        if (visibility >= 0)
        {
            this.visibility = visibility;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    //overloaded constructor which takes the location, activity, visibility
    public Obscuration(string location, bool activity, int visibility) : base(location, activity)
    {
        this.visibility = visibility;
    }


    //overriden ToString() method which calls base ToString()
    public override string ToString()
    {
        string obscuration = "";
        if (visibility >= 56)
        {
            obscuration = base.ToString() + "\nVisibility: Normal";
        }
        else
        {
            obscuration = base.ToString() + "\nVisibility: " + this.visibility  + " / 8 mi";
        }
        return obscuration;
    }
}