using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class myCollection
{
    public static void Main(string[] args)
    {
        //create the List of Item called items to store the user's items
        List<Item> items = new List<Item>();

        //loop to collect 5 items from the user
        for (int i = 0; i < 5; i++)
        {
            //prompt the user to pick a book or periodical
            Console.WriteLine("Please enter B for Book or P for Periodical");
            string input = Console.ReadLine();

            //option B for book
            if (input.Equals("B"))
            {
                Console.WriteLine("Please enter the name of the Book");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter the author of the Book");
                string author = Console.ReadLine();
                Console.WriteLine("Please enter the ISBN of the book");
                int ISBN = Int32.Parse(Console.ReadLine());
                Book book = new Book(ISBN, author, title);
                items.Add(book);
            }


            //option P for periodical
            if (input.Equals("P"))
            {
                Console.WriteLine("Please enter the name of the Periodical");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter the issue number");
                int issueNum = Int32.Parse(Console.ReadLine());
                Periodical periodical = new Periodical(issueNum, title);
                items.Add(periodical);
            }
        }
        //print back all 5 items to the user
        Console.WriteLine("Your Items:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(items[i].getListing());
            Console.WriteLine();
        }
    }
}