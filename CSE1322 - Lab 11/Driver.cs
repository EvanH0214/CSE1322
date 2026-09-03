using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        BlueRayCollection blueRayCollection = new BlueRayCollection();

        bool cont = true;
        while (cont)
        {
            Console.WriteLine("0. Quit \n1. Add BlueRay to collection \n2. See collection");
            int input = Int32.Parse(Console.ReadLine());

            if (input == 0)
            {
                cont = false;
            }

            if (input == 1)
            {
                Console.WriteLine("What is the title? ");
                string title = Console.ReadLine();
                Console.WriteLine("What is the director? ");
                string director = Console.ReadLine();
                Console.WriteLine("What is the year of release?");
                int year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is the cost?");
                double cost = double.Parse(Console.ReadLine());
                blueRayCollection.add(title, director, year, cost);
            }

            if (input == 2)
            {
                blueRayCollection.show_all();
            }
        }
    }
}
