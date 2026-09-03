using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class WeatherEvent
{
    //private string attribute called location
    //private static int attribute called nextID initialized at 0
    //private int attribute called id
    //private bool attribute called active
    private string location;
    private static int nextId = 0;
    private int id;
    private bool active;


    //overloaded constructer which takes in a string and bool and sets id
    public WeatherEvent(string location, bool active)
    {
        this.location = location;
        this.active = active;
        this.id = nextId++;
    }


    //getter for all fields except nextID
    public string getLocation()
    {
        return this.location;
    }
    public int getId()
    {
        return this.id;
    }
    public bool getActive()
    {
        return this.active;
    }


    //setter for location and active
    public void setLocation(string location)
    {
        this.location = location;
    }
    public void setActive(bool active)
    {
        this.active = active;
    }


    //overrided toString() method 
    //"Weather Event Location: " + location + "\nid: " + id + "\nactive: " + active
    public override string ToString()
    {
        string weather = "Weather Event Location: " + this.location + "\nid: " + this.id + "\nactive: " + this.active;
        return weather;
    }
}
