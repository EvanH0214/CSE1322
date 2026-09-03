using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Periodical : Item
{
    //private int attribute called issueNum
    private int issueNum;


    //getter/setter for issueNum
    public int getIssueNum()
    {
        return this.issueNum;
    }

    public void setIssueNum(int issueNum)
    {
        this.issueNum = issueNum;
    }

    //constructor which takes no arguments
    public Periodical()
    {
        this.issueNum = 0;
    }


    //overloaded constructor which sets all attributes in Periodical and Item classes
    public Periodical(int issueNum, string title)
    {
        this.issueNum = issueNum;
        setTitle(title);
    }


    //concrete getListing() method that returns a string
    //"Peridocal Title" - Title \n "Issue #" - Issue number
    public override string getListing()
    {
        string listing = "Periodical Title - " + getTitle() + "\nIssue # - " + getIssueNum();
        return listing;
    }
}
