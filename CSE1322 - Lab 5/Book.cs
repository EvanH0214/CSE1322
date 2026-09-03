using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book : Item
{
    //private int attribute called ISBN
    //private string attribute called author
    private int ISBN;
    private string author;


    //getters and setters for both attributes
    public int getISBN()
    {
        return ISBN;
    }
    public string getAuthor()
    {
        return author;
    }

    public void setISBN(int ISBN)
    {
        this.ISBN = ISBN;
    }
    public void setAuthor(string author)
    {
        this.author = author;
    }


    //constructor with no parameters
    public Book()
    {
        
    }


    //overloaded constructor which sets all attributes from this and Item class
    public Book(int ISBN, string author, string title)
    {
        this.ISBN = ISBN;
        this.author = author;
        setTitle(title);
    }


    //getListing() concrete method which returns a string
    //returns "Book Name - Title \n Author - Author \n ISBN # - ISBN number"

    public override string getListing()
    {
        string listing = "Book Name - " + getTitle() + "\nAuthor - " + this.author + "\nISBN # - " + this.ISBN;
        return listing;
    }
    


}
