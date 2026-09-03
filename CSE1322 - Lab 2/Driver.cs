using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

class Driver {


    

    public static void Main(string[] args)
    {

        //create milk and bread objects with specified attributes
        StockItem milk = new StockItem("1 Gallon of Milk", 3.60, 15);
        StockItem bread = new StockItem("1 loaf of Break", 1.98, 30);

        //while loop to loop until user selects to quit
        bool cont = true;
        while (cont == true)
        {


            //print out all options for the user to pick from

            Console.WriteLine("1. Sold One Milk");
            Console.WriteLine("2. Sold One Bread");
            Console.WriteLine("3. Change price of Milk");
            Console.WriteLine("4. Change price of Bread");
            Console.WriteLine("5. Add Milk to Inventory");
            Console.WriteLine("6. Add Bread to Inventory");
            Console.WriteLine("7. See Inventory");
            Console.WriteLine("8. Quit");

            string input = Console.ReadLine();


            //option 1 to sell milk
            //call the lowerQuantity method
            if(input == "1")
            {
                milk.lowerQuantity();
            }



            //option 2 to sell bread
            //call the lowerQuantity method
            if (input == "2") 
            { 
                bread.lowerQuantity();
            }



            //option 3 to change price of milk
            //create a loop to ensure user gives a valid price
            //collect new price from user
            //call setPrice method
            if(input == "3")
            {
                bool validprice = false;
                while (validprice == false)
                {
                    Console.WriteLine("What is the new price for Milk");
                    double newPrice = double.Parse(Console.ReadLine());
                    if(newPrice >= 0)
                    {
                        milk.setPrice(newPrice);
                        validprice = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid price");
                    }
                }
                
            }



            //option 4 to change price of bread
            //create a loop to ensure user gives a valid price
            //collect new price from user
            //call setPrice method
            if (input == "4")
            {
                bool validprice = false;
                while (validprice == false)
                {
                    Console.WriteLine("What is the new price for Bread");
                    double newPrice = double.Parse(Console.ReadLine());
                    if(newPrice >= 0)
                    {
                        bread.setPrice(newPrice);
                        validprice = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid price");
                    }
                }
            }


            //option 5 to add milk
            //collect amount added from user
            //call raiseQuantity method
            if(input == "5")
            {
                Console.WriteLine("How many milk did we get?");
                int newMilks = int.Parse(Console.ReadLine());
                milk.raiseQuantity(newMilks);
            }



            //option 6 to add bread
            //collect amount added from user
            //call raiseQuantity method
            if(input == "6")
            {
                Console.WriteLine("How many bread did we get");
                int newBreads = int.Parse(Console.ReadLine());
                bread.raiseQuantity(newBreads);
            }


            //option 7 to print id number, amount, description, and price of milk and bread
            //use toString method from StockItem class
            if (input == "7")
            {
                Console.Write("Milk: ");
                Console.WriteLine(milk);
                Console.Write("Bread: ");
                Console.WriteLine(bread);
            }


            //option 8 to quit
            //exit the while loop.
            if(input == "8")
            {
                cont = false;
            }
        }

    }
}

    