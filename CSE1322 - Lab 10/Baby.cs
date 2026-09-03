using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Baby
{
    private int time;
    private string name;

    public Baby(string name)
    {
        this.name = name;
        Random random = new Random();
        this.time = random.Next(5000);
    }

    public void Run()
    {
        try
        {
            Console.WriteLine("My name is " + this.name + " and I am going to sleep for " + this.time + "ms");
            Thread.Sleep(time);
            Console.WriteLine("My name is " + this.name + " and I'm awake, feed me!!!");
        }
        catch (ThreadInterruptedException tie) 
        {
            Console.WriteLine(tie.Message);
        }
    }
}
