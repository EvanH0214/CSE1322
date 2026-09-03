using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Federal Court Complaint Processor]");
        Console.Write("Enter file name to process: ");
        string file = Console.ReadLine();

        int accepted = 0;
        int remanded = 0;

        try
        {
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');
                Complaint c = new Complaint(line[0], double.Parse(line[1]), line[2], line[3], line[4]);

                try
                {
                    processComplaint(c);
                    StreamWriter sw = new StreamWriter("accepted.txt", true);
                    sw.WriteLine("Case ID: " + c.getId() + "\nCause of action: " + c.getCauseOfAction() + "\nAmount in Controversy: " + c.getAmountInControversy() + "\nPantiff's Citizenship: " + c.getPlantiffCitizenship() + "\nDefendant's Citizenship " + c.getDefendantCitizenship() + "\nOriginally filled in: " + c.getOriginalStateOfFilling() + "\n=============================");
                    sw.Close();
                    accepted++;
                }
                catch (StateComplaintException e)
                {
                    StreamWriter sw = new StreamWriter("remanded.txt", true);
                    sw.WriteLine("Case ID: " + c.getId() + "\nCause of action: " + c.getCauseOfAction() + "\nAmount in Controversy: " + c.getAmountInControversy() + "\nPantiff's Citizenship: " + c.getPlantiffCitizenship() + "\nDefendant's Citizenship " + c.getDefendantCitizenship() + "\nOriginally filled in: " + c.getOriginalStateOfFilling() + "\n\nReason for remand: " + e.Message + "\n==============================");
                    remanded++;
                    sw.Close();
                }
            }
            Console.WriteLine("Processing complete. Accepted cases written to accepted.txt and remanded cases written to remanded.txt \nNumber of remanded cases:" + remanded + "\nNumber of accepted cases: " + accepted + "\nSutting down...");
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("No file with name '" + file + "' \nShutting down...");
        }
    }

    public static void processComplaint(Complaint c)
    {
        if (c.getCauseOfAction().Equals("Equal Protection Challenge")) { }
        else if (c.getCauseOfAction().Equals("Title IX Workplace Discrimination")) { }
        else if (c.getCauseOfAction().Equals("Prisoner Civil Rights Claim")) { }
        else if (c.getCauseOfAction().Equals("Fair Labor Standard Act Claim")) { }
        else if (c.getPlantiffCitizenship().Equals(c.getDefendantCitizenship())) { throw new StateComplaintException("Lack of Diversity"); }
        else if (c.getAmountInControversy() <= 75000) { throw new StateComplaintException("Amount in controversy less than or equal to $75000"); }
        else if (c.getDefendantCitizenship().Equals(c.getOriginalStateOfFilling())) { throw new StateComplaintException("No prejudice through diversity"); }

    }
}


