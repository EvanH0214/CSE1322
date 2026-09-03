using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Store
{
    private MerchandiseStorage pile;
    private static int totalRevenue = 0;
    private static int itemsSold = 0;
    private static int nextId = 1;
    private int id;

    public Store(MerchandiseStorage pile)
    {
        this.pile = pile;
        this.id = nextId++;
    }

    public static int getTotalRevenue()
    {
        return totalRevenue;
    }

    public static int getItemsSold()
    {
        return itemsSold;
    }

    public void Run()
    {
        lock (pile)
        {
            string current = pile.retrieveMerchandise();

            while (!current.Equals(""))
            {
                itemsSold++;
                if (current.Equals("keychain"))
                {
                    totalRevenue += 5;
                }
                if (current.Equals("t-shirt"))
                {
                    totalRevenue += 30;
                }
                if (current.Equals("plush"))
                {
                    totalRevenue += 50;
                }
                current = pile.retrieveMerchandise();
            }
        }
        Console.WriteLine("Store " + this.id + " is done selling");
    }
}
