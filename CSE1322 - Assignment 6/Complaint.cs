using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Complaint
{
    private string causeOfAction;
    private string plantiffCitizenship;
    private string defendantCitizenship;
    private string originalStateOfFilling;
    private double amountInControversy;
    private int id;
    private static int nextID;

    public string getCauseOfAction()
    {
        return this.causeOfAction;
    }
    public string getPlantiffCitizenship()
    {
        return this.plantiffCitizenship;
    }

    public string getDefendantCitizenship()
    {
        return this.defendantCitizenship;
    }
    public string getOriginalStateOfFilling()
    {
        return this.originalStateOfFilling;
    }
    public double getAmountInControversy()
    {
        return this.amountInControversy;
    }
    public int getId()
    {
        return this.id;
    }

    public Complaint(string causeOfAction, double amountInControversy, string plantiffCitizenship, string defendantCitizenship, string originalStateOfFilling)
    {
        this.causeOfAction = causeOfAction;
        this.amountInControversy = amountInControversy;
        this.plantiffCitizenship = plantiffCitizenship;
        this.defendantCitizenship = defendantCitizenship;
        this.originalStateOfFilling = originalStateOfFilling;
        this.id = nextID++;
    }
}
