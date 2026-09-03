using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        FibIteration fibIteration = new FibIteration();
        FibFormula fibFormula = new FibFormula();

        Console.WriteLine("Enter the number you want to find the Fibonacci Series for");
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Fib of " + input + " by iteration is: " + fibIteration.calculate_fib(input));
        Console.WriteLine("Fib of " + input + " by formula is: " + fibFormula.calculate_fib(input));
    }
}