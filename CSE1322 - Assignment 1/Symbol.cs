using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Symbol
{
    //3 fields to track information
    public char symbol;
    public int uses;
    public double frequency;

    //overloaded constructor
    public Symbol (char symbol)
    {
        this.symbol = symbol;
        this.uses = 0;
        this.frequency = 0;
    }



}
