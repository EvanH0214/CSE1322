using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Particle : Obscuration
{
    //private string attribute called particleType
    private string particleType;


    //getter and setter for particleType
    //particleType can only be dust, sand, ash
    //set anything else to other
    public string getParticleType()
    {
        return this.particleType;
    }
    public void setParticleType(string particleType)
    {
        if (particleType.Equals("Dust") || particleType.Equals("Sand") || particleType.Equals("Ash"))
        {
            this.particleType = particleType;
        }
        else
        {
            this.particleType = "other";
        }
    }


    //overloaded constructor which takes location, active, visibility, particleType
    //call base constructor for location, active, and visibility
    public Particle(string location, bool active, int visibility, string particleType) : base(location, active, visibility)
    {
        if (particleType.Equals("Dust") || particleType.Equals("Sand") || particleType.Equals("Ash"))
        {
            this.particleType = particleType;
        }
        else
        {
            this.particleType = "other";
        }
    }


    //overriden ToString() method which calls base ToString()
    public override string ToString()
    {
        string particle = base.ToString() + "\nParticle type: " + this.particleType;
        return particle;
    }
}