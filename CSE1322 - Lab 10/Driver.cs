using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Driver
{
    public static void Main(string[] args)
    {
        Baby b1 = new Baby("Noah");
        Baby b2 = new Baby("Olivia");
        Baby b3 = new Baby("Liam");
        Baby b4 = new Baby("Emma");
        Baby b5 = new Baby("Amelia");

        Thread t1 = new Thread(b1.Run);
        Thread t2 = new Thread(b2.Run);
        Thread t3 = new Thread(b3.Run);
        Thread t4 = new Thread(b4.Run);
        Thread t5 = new Thread(b5.Run);

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        t5.Start();
    }
}