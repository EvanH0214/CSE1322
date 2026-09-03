using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Question
{
    //3 private attributes for the question, answer, and difficulty
    private string question;
    private string answer;
    private int difficulty;


    //constructor which takes in all 3 class attributes as parameters and sets each one
    public Question(string question, string answer, int difficulty)
    {
        this.question = question;
        this.answer = answer;
        this.difficulty = difficulty;
    }


    //getters for each class attribute
    public string getQuestion()
    {
        return question;
    }
    public string getAnswer()
    {
        return answer;
    }
    public int getDifficulty()
    {
        return difficulty;
    }


    //setters for each class attribute
    public void setQuestion(string question)
    {
        this.question = question;
    }
    public void setAnswer(string answer)
    {
        this.answer = answer;
    }
    public void setDifficulty(int difficulty)
    {
        this.difficulty = difficulty;
    }

}
