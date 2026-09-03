using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Fog : Obscuration
{
    //private bool attribute called freezingFog
    private bool freezingFog;


    //getter and setter for freezingFog
    public bool getFreezingFog()
    {
        return this.freezingFog;
    }
    public void setFreezingFog(bool freezingFog)
    {
        this.freezingFog = freezingFog;
    }


    //overloaded constructor which takes location, active, visibility, freezingFog
    //calls base constructor for location, active, and visibility
    public Fog(string location, bool active, int visibility, bool freezingFog) : base(location, active, visibility)
    {
        this.freezingFog = freezingFog;
    }


    //overriden setVisibility() method
    public override void setVisibility(int visibility)
    {
        if (visibility < 1)
        {
            base.setVisibility(1);
        }
        else if (visibility > 4)
        {
            base.setVisibility(4);
        }
        else
        {
            base.setVisibility(visibility);
        }
    }


    //overrided ToString() method which calls the base ToString()
    public override string ToString()
    {
        string fog = "";
        if (freezingFog)
        {
            fog = base.ToString() + "\nALERT! FREEZING FOG!";
        }
        return fog;
    }
}
