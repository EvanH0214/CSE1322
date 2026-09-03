using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Driver
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("First file name: ");
            string file1 = Console.ReadLine();

            StreamReader sr1 = new StreamReader(file1);

            Console.Write("Second file name: ");
            string file2 = Console.ReadLine();

            StreamReader sr2 = new StreamReader(file2);

            Console.WriteLine();

            int sr1Count = File.ReadLines(file1).Count();
            int sr2Count = File.ReadLines(file2).Count();

            int i = 1;
            while (!sr1.EndOfStream && !sr2.EndOfStream)
            {
                string line1 = sr1.ReadLine();
                string line2 = sr2.ReadLine();
                if (!(line1.Equals(line2)))
                {
                    Console.WriteLine("Line " + i + "\n<" + line1 + "\n>" + line2);
                }
                i++;
            }
            if (sr1Count != sr2Count)
            {
                Console.WriteLine("Files have different number of lines");
            }
        }
        catch(IOException ioex)
        {
            Console.WriteLine(ioex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


}
