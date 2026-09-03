using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Merchandise
{
    public string merchandise;
    public Merchandise next;

    public Merchandise(string merchandise)
    {
        this.merchandise = merchandise;
        this.next = null;
    }
}
