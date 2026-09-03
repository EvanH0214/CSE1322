using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BlueRayDisk
{
    public string title;
    public string director;
    public int yearOfRelease;
    public double cost;

    public BlueRayDisk(string title, string director, int yearOfRelease, double cost)
    {
        this.title = title;
        this.director = director;
        this.yearOfRelease = yearOfRelease;
        this.cost = cost;
    }

    public override string ToString()
    {
        return "$" + this.cost + " " + this.yearOfRelease + " " + this.title + ", " + this.director;
    }
}
