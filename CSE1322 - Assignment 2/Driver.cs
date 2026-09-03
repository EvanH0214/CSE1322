using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        Bill bill = new Bill();

        Console.WriteLine("[Bill Generator]");
        Console.WriteLine("New bill created");

        //while loop to continue until user chooses to quit
        bool cont = true;
        while (cont)
        {
            //prompt the user with all 8 options: add item, remove item, add subitem, remove subitem, see tax, set tax, finish
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Add subitem");
            Console.WriteLine("4. Remove subitem");
            Console.WriteLine("5. See tax");
            Console.WriteLine("6. Set tax");
            Console.WriteLine("7. Preview bill");
            Console.WriteLine("8. Finish");
            Console.Write("Select option: ");
            int input = Int32.Parse(Console.ReadLine());


            //option 1: add item
            //ask user for BillingItem's description and ammount
            //create another BillingItem with information and add it to Bill arraylist
            if (input == 1)
            {
                Console.Write("Enter the item's description: ");
                string description = Console.ReadLine();
                Console.Write("Enter the item's amount: ");
                double amount = double.Parse(Console.ReadLine());
                BillingItem item = new BillingItem(amount, description);
                bill.addItem(item);
                Console.WriteLine("Item added to bill");
            }


            //option 2: remove item
            //print all BillingItems and ask which one the user wants to remove
            //remove BillingItem if it is valid
            if (input == 2)
            {
                if (bill.getItem(0) == null)
                {
                    Console.WriteLine("There are no items to remove!");
                }
                else
                {
                    Console.Write(bill.seeItems());
                    Console.Write("Select item to remove: ");
                    int index = Int32.Parse(Console.ReadLine());
                    if (index < bill.getLength())
                    {
                        bill.removeItem(bill.getItem(index));
                        Console.WriteLine("Item removed from bill.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid item to remove!");
                    }
                }
            }


            //option 3: add subitem
            //print all BillingItems and prompt user to pick one
            //prompt user for BillingSubItem's description and amount
            //create new BillingSubItem and add to BillingItem
            if (input == 3)
            {
                Console.Write(bill.seeItems());
                Console.Write("Select an item: ");
                int index = Int32.Parse(Console.ReadLine());
                Console.Write("Enter subitem's description: ");
                string description = Console.ReadLine();
                Console.Write("Enter subitem's amount: ");
                int amount = Int32.Parse(Console.ReadLine());
                BillingSubItem subItem = new BillingSubItem(amount, description);
                bill.getItem(index).addSubItem(subItem);
                Console.WriteLine("Subitem added to item. ");
            }


            //option 4: remove subitem
            //print all BillingItems and prompt user to pick one
            //print all BillingSubItems in chosen BillingItem and ask the user to pick one
            //remove chosen BillingSubItem
            if (input == 4)
            {
                if (bill.getItem(0) == null)
                {
                    Console.WriteLine("There are no items from which you can remove subitems!");
                }
                else
                {
                    Console.Write(bill.seeItems());
                    Console.Write("Select an item: ");
                    int index = Int32.Parse(Console.ReadLine());
                    if (bill.getItem(index).getSubItem(0) == null)
                    {
                        Console.WriteLine("That item has no subitems!");
                    }
                    if (index < bill.getItem(index).getLength())
                    {
                        Console.Write(bill.getItem(index).seeSubItems());
                        Console.Write("Select subitem to remove: ");
                        int subIndex = Int32.Parse(Console.ReadLine());
                        bill.getItem(index).removeSubItem(bill.getItem(index).getSubItem(subIndex));
                    }
                }
            }


            //option 5: see tax
            //print current tax percentage
            if (input == 5)
            {
                Console.WriteLine("current tax is " + Bill.getTaxPercentage() + "%");
            }


            //option 6: set tax
            //prompt user for new tax percentage and set tax percentage
            if (input == 6)
            {
                Console.Write("Enter new tax %: ");
                double newTax = double.Parse(Console.ReadLine());
                bill.setTax(newTax);
                Console.WriteLine("Tax set.");
            }


            //option 7: preview bill
            //print out Bill's toString()
            if (input == 7)
            {
                Console.WriteLine("The current contents of the bill are: ");
                Console.WriteLine(bill);
            }



            //option 8: finish
            //print out Bill's toString()
            //ask user if they want to create another Bill
            //if Yes, reinitialize Bill and restart program
            //if No, end program
            if (input == 8)
            {
                Console.WriteLine(bill);
                Console.Write("Would you like to create a new bill? (say ''no'' to terminate) ");
                string answer = Console.ReadLine();
                if (answer.Equals("no"))
                {
                    cont = false;
                    Console.WriteLine("\n Shutting off...");
                }
                else
                {
                    bill = new Bill();
                    Console.WriteLine("New bill created. \n");
                }
                
            }
        }

    }
}