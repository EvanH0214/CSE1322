using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lab7a
{
    public static int recursive_multiply(int n, int m)
    {
        if (m == 0)
        {
            return 0;
        }
        int product = n + recursive_multiply(n, m - 1);
        return product;
    }

    public static int recursive_div(int n, int m)
    {
        if (m == 0)
        {
            return -1;
        }
        if (m == n)
        {
            return 1;
        }
        if (m > n)
        {
            return 0;
        }
        return 1 + recursive_div(n - m, m);
    }

    public static int recursive_mod(int n, int m)
    {
        if (m == 0)
        {
            return -1;
        }
        if (m > n)
        {
            return n;
        }
        return recursive_mod(n - m, m);
    }

    public static void Main(string[] args)
    {
        bool cont = true;
        while (cont)
        {
            Console.WriteLine("Choose from the following: \n0. Quit \n1. Multiply 2 numbers \n2. Div 2 numbers \n3. Mod 2 numbers");
            int input = Int32.Parse(Console.ReadLine());

            if (input == 0)
            {
                cont = false;
            }


            if (input == 1)
            {
                Console.WriteLine("Enter first number");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int m = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Answer:" + recursive_multiply(n, m));
            }


            if (input == 2)
            {
                Console.WriteLine("Enter first number ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int m = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Answer: " + recursive_div(n, m));
            }


            if (input == 3)
            {
                Console.WriteLine("Enter first number ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int m = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Answer: " + recursive_mod(n, m));
            }
        }
    }

}
