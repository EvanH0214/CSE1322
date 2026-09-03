using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BlueRayCollection
{
    private Node head = null;

    public void add(string title, string director, int year, double cost)
    {
        Node temp = new Node();
        temp.blueRayDisk = new BlueRayDisk(title, director, year, cost);
        temp.next = null;
        if (head == null)
        {
            head = temp;
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = temp;
        }

    }

    public void show_all()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.blueRayDisk.ToString());
            current = current.next;
        }

    }
}
