using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibIteration : IFindFib
{
    public int calculate_fib(int fibNumber)
    {
        if (fibNumber == 1 || fibNumber == 2)
        {
            return 1;
        }
        else
        {
            int total = 0;
            int n1 = 1;
            int n2 = 1;
            for (int i = 3; i <= fibNumber; i++)
            {
                total = n1 + n2;
                n2 = n1;
                n1 = total;
            }
            return total;
        }
    }
}