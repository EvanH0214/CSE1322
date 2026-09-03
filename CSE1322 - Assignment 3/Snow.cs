using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Snow : Percipitation
{
    //private double attribute called temperature
    private double temperature;


    //getter and setter for temperature
    //temperature cannot be below -459.67 or above 32
    public double getTemperature()
    {
        return this.temperature;
    }
    public void setTemperature(double temperature)
    {
        if (this.temperature < -459.67)
        {
            temperature = -459.67;
        }
        else if (this.temperature > 32)
        {
            temperature = 32;
        }
        this.temperature = temperature;
    }


    //overloaded constructor which takes location, active, rateOfFall, temperature
    //call base constructor for location, active, and rateOfFall
    public Snow(string location, bool active, double rateOfFall, double temperature) : base(location, active, rateOfFall)
    {
        if (temperature < -459.67)
        {
            temperature = -459.67;
        }
        else if (temperature > 32)
        {
            temperature = 32;
        }
        this.temperature = temperature;
    }


    //overrided ToString() method which calls the base ToString()
    public override string ToString()
    {
        string temp = base.ToString() + "\nTemperature: " + this.temperature + " F";
        return temp;
    }
}
