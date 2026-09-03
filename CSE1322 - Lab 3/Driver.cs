using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        Quiz quiz = new Quiz();

        //while loop to continue the program until the user selects quit
        bool cont = true;
        while (cont)
        {
            //present the user with all of their options
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Add a question to the quiz");
            Console.WriteLine("2. Remove a question from the quiz");
            Console.WriteLine("3. Modify a question in the quiz");
            Console.WriteLine("4. Take the quiz");
            Console.WriteLine("5. Quit");

            //collect the users choice
            int input = Int32.Parse(Console.ReadLine());


            //option 1 to add a question
            //call the add_question() method
            if (input == 1)
            {
                quiz.add_question();
            }


            //option 2 to remove a question
            //call the remove_question() method
            if (input == 2)
            {
                quiz.remove_question();
            }

            //option 3 to modify a question
            //call the modify_question() method
            if (input == 3)
            {
                quiz.modify_question();
            }


            //option 4 to take the quiz
            //call the give_quiz() method
            if (input == 4)
            {
                quiz.give_quiz();
            }


            //option 5 to quit the program
            //set cont to false
            if (input == 5)
            {
                cont = false;
            }


        }
    }
}

