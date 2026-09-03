using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Quiz
{
    //list of question objects using question class
    List<Question> questions = new List<Question>();


    //add_question() method
    //prompt user for new question, answer, and difficulty
    //create question object and add to arraylist
    public void add_question()
    {
        Console.WriteLine("What is the question Text? ");
        string question = Console.ReadLine();

        Console.WriteLine("What is the answer?");
        string answer = Console.ReadLine();

        Console.WriteLine("How Difficult (1-3)?");
        int difficulty = Int32.Parse(Console.ReadLine());

        Question newQuestion = new Question(question, answer, difficulty);
        questions.Add(newQuestion);
    }


    //remove_question() method 
    //present all questions and ask user which to remove
    //remove question from arraylist
    public void remove_question()
    {
        bool cont = true;
        while (cont)
        {
            Console.WriteLine("Choose the question to remove?");
            for (int i = 0; i < questions.Count(); i++)
            {
                Console.WriteLine(i + ". " + questions[i].getQuestion());
            }
            int input = Int32.Parse(Console.ReadLine());
            if (input >= 0 && input < questions.Count())
            {
                questions.RemoveAt(input);
                cont = false;
            }
            else
            {
                Console.WriteLine("That is not a valid question.");
            }
        }
    }


    //modify_question() method
    //list of all question texts and ask which to change
    //ask user for new question, answer, and difficulty
    //replace appropriate question in arraylist
    public void modify_question()
    {
        bool cont = true;
        while (cont)
        {
            Console.WriteLine("Choose question to modify?");
            for (int i = 0; i < questions.Count(); i++)
            {
                Console.WriteLine(i + ". " + questions[i].getQuestion());
            }
            int input = Int32.Parse(Console.ReadLine());
            if (input >= 0 && input < questions.Count())
            {
                Console.WriteLine("What is the question Text?");
                string question = Console.ReadLine();
                Console.WriteLine("What is the answer?");
                string answer = Console.ReadLine();
                Console.WriteLine("How Difficult (1-3)?");
                int difficulty = Int32.Parse(Console.ReadLine());
                Question newQuestion = new Question(question, answer, difficulty);
                questions.RemoveAt(input);
                questions.Insert(input, newQuestion);
                cont = false;
            }
            else
            {
                Console.WriteLine("That is not a valid question.");
            }
        }
    }



    //give_quiz() method
    //present user with each question and ask them to answer
    //tell user if they are right or wrong
    //keep track of score and tell total score at end
    public void give_quiz()
    {
        int score = 0;
        for (int i = 0; i < questions.Count(); i++)
        {
            Console.WriteLine(questions[i].getQuestion());
            string answer = Console.ReadLine();
            if (answer.Equals(questions[i].getAnswer()))
            {
                Console.WriteLine("Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
        Console.WriteLine("You got " + score + " out of " + questions.Count());
    }
}