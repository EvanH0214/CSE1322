using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MerchandiseStorage
{
    private Merchandise top;

    public void addMerchandise(string name)
    {
        Merchandise merchandise = new Merchandise(name);
        merchandise.next = top;
        top = merchandise;
    }

    public string retrieveMerchandise()
    {
        if (top == null)
        {
            return "";
        }
        string merch = top.merchandise;
        top = top.next;
        return merch;
    }
}
