using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{

    //main method
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;



        //create an array of Symbols of size 9
        Symbol[] symbols = new Symbol[9];

        //fill with symbols from the chart using Symbol constructor;
        symbols[0] = new Symbol('\u221E');
        symbols[1] = new Symbol('\u263A');
        symbols[2] = new Symbol('\u2640');
        symbols[3] = new Symbol('\u2642');
        symbols[4] = new Symbol('\u2660');
        symbols[5] = new Symbol('\u2663');
        symbols[6] = new Symbol('\u2665');
        symbols[7] = new Symbol('\u2666');
        symbols[8] = new Symbol('\u266B');

        //loop to print options 1 - 0 to the user
        bool cont = true;
        while (cont)
        {
            Console.WriteLine("1 - " + symbols[0].symbol);
            Console.WriteLine("2 - " + symbols[1].symbol);
            Console.WriteLine("3 - " + symbols[2].symbol);
            Console.WriteLine("4 - " + symbols[3].symbol);
            Console.WriteLine("5 - " + symbols[4].symbol);
            Console.WriteLine("6 - " + symbols[5].symbol);
            Console.WriteLine("7 - " + symbols[6].symbol);
            Console.WriteLine("8 - " + symbols[7].symbol);
            Console.WriteLine("9 - " + symbols[8].symbol);
            Console.WriteLine("0 - Exit");
            Console.Write("Please select a symbol to print: ");

            //read number from user
            string input = Console.ReadLine();

            //print selected symbol
            //increase chosen symbol frequency by 1
            //call updateFrequencies()
            //call sortSymbols()
            if (input == "1")
            {
                Console.WriteLine("You selected the " + symbols[0].symbol + " symbol.");
                symbols[0].uses += 1;
            }

            else if (input == "2")
            {
                Console.WriteLine("You selected the " + symbols[1].symbol + " symbol.");
                symbols[1].uses += 1;
            }
            
            else if (input == "3")
            {
                Console.WriteLine("You selected the " + symbols[2].symbol + " symbol.");
                symbols[2].uses += 1;
            }

            else if (input == "4")
            {
                Console.WriteLine("You selected the " + symbols[3].symbol + " symbol.");
                symbols[3].uses += 1;
            }

            else if (input == "5")
            {
                Console.WriteLine("You selected the " + symbols[4].symbol + " symbol.");
                symbols[4].uses += 1;
            }

            else if (input == "6")
            {
                Console.WriteLine("You selected the " + symbols[5].symbol + " symbol.");
                symbols[5].uses += 1;
            }
             
            else if (input == "7")
            {
                Console.WriteLine("You selected the " + symbols[6].symbol + " symbol.");
                symbols[6].uses += 1;
            }

            else if (input == "8")
            {
                Console.WriteLine("You selected the " + symbols[7].symbol + " symbol.");
                symbols[7].uses += 1;
            }

            else if (input == "9")
            {
                Console.WriteLine("You selected the " + symbols[8].symbol + " symbol.");
                symbols[8].uses += 1;
            }

            else if (input == "0")
            {
                cont = false;
            }

            else
            {
                Console.WriteLine("That is not a valid option. ");
            }


            updateFrequencies(symbols);
            sortSymbols(symbols);

        }


    }




    //updateFrequncies method
    //static
    //Take in a Symbol array as input
    //no output
    //count total number of times symbols have been used
    //update individual frequencies
    public static void updateFrequencies(Symbol[] symbols)
    {
        int total = 0;
        for (int i = 0; i < symbols.Length; i++)
        {
            total += symbols[i].uses;
        }
        for (int i = 0; i < symbols.Length; i++)
        {
            symbols[i].frequency = symbols[i].uses / (double) total;
        }
    }




    //sortSymbols method
    //static
    //Symbol array input, no output
    //sort symbols by decending frequency
    //highest frequency in index 0
    //lowest frequency in last index
    //if 2 symbols tie, sort by codepoint value (lower first)

    public static void sortSymbols(Symbol[] symbols)
    {
        Symbol tempSymbol;
        for (int i = 0; i < symbols.Length - 1; i++)
        {
            for (int j = 0; j < symbols.Length - i - 1; j++)
            {
                if (symbols[j].frequency < symbols[j + 1].frequency)
                {
                    tempSymbol = symbols[j + 1];
                    symbols[j + 1] = symbols[j];
                    symbols[j] = tempSymbol;
                }

                else if (symbols[j].frequency == symbols[j + 1].frequency)
                {
                    if (symbols[j].symbol > symbols[j + 1].symbol)
                    {
                        tempSymbol = symbols[j + 1];
                        symbols[j + 1] = symbols[j];
                        symbols[j] = tempSymbol;
                    }
                }
            }
        }
    }


    
}