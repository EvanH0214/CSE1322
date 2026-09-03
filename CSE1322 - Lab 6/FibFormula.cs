using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibFormula : IFindFib
{
    public int calculate_fib(int fibNumber)
    {
        double total = (Math.Pow(((1 + Math.Sqrt(5)) / 2), fibNumber) - Math.Pow(((1 - Math.Sqrt(5)) / 2), fibNumber)) / Math.Sqrt(5);
        return (int) total;
    }
}
