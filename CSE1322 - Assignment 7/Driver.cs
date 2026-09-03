using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        MerchandiseStorage merchandiseStorage = new MerchandiseStorage();

        Console.WriteLine("[Store Management System]");

        Console.Write("How many keychains are being sold? ");
        int keychains = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < keychains; i++)
        {
            merchandiseStorage.addMerchandise("keychain");
        }

        Console.Write("How many t-shirts are being sold? ");
        int shirts = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < shirts; i++)
        {
            merchandiseStorage.addMerchandise("t-shirt");
        }

        Console.Write("How many plushies are being sold? ");
        int plushies = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < plushies; i++)
        {
            merchandiseStorage.addMerchandise("plush");
        }

        Console.WriteLine("Storage has been stocked. Press any key to start selling...");

        Store s1 = new Store(merchandiseStorage);
        Store s2 = new Store(merchandiseStorage);
        Store s3 = new Store(merchandiseStorage);

        Thread keychain = new Thread(s1.Run);
        Thread shirt = new Thread(s2.Run);
        Thread plush = new Thread(s3.Run);

        keychain.Start();
        shirt.Start();
        plush.Start();

        keychain.Join();
        shirt.Join();
        plush.Join();

        Console.WriteLine("Total revenue: $" + Store.getTotalRevenue() + "\nNumber of items sold: " + Store.getItemsSold() + "\nThe show was a success!");
    }
}