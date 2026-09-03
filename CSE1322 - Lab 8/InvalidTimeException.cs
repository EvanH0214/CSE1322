using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidTimeException : Exception
{
    public InvalidTimeException(string a) : base(a) { }

    public InvalidTimeException() { }
}