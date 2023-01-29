using System;
using System.Collections.Generic;

public class Quiz{
    private List<Question> questions = new List<Question>();
    private int numCorrect;

    public void addQuestion(){
        Console.Write("What would you like the question to be? ");
        string question = Console.ReadLine();
        Console.Write("What would you like the answer to be? " );
        string answer = Console.ReadLine();
        Console.Write("What is the difficulty (1-3)? ");
        int diff = Convert.ToInt16(Console.ReadLine());
        questions.Add(new Question(question, answer, diff));
    }

    public void removeQuestion(){
        Console.WriteLine("Which question would you like to remove?");
        for(int i = 0; i < questions.Count; i++){
            Console.WriteLine("{0}: {1}", i + 1, questions[i].questionText);
        }
        while(true){
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            if(choice < 0 || choice >= questions.Count){
                Console.WriteLine("Invalid choice");
                continue;
            }
            questions.RemoveAt(choice);
            break;
        }
    }

    public void modifyQuestion(){
        Console.WriteLine("Which question would you like to modify?");
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine("{0}: {1}", i + 1, questions[i].questionText);
        }
        int choice;
        while (true)
        {
            choice = Convert.ToInt32(Console.ReadLine()) - 1;
            if (choice < 0 || choice >= questions.Count)
            {
                Console.WriteLine("Invalid choice");
                continue;
            }
            break;
        }
        Console.Write("What would you like the question to be? ");
        string question = Console.ReadLine();
        Console.Write("What would you like the answer to be? ");
        string answer = Console.ReadLine();
        Console.Write("What is the difficulty (1-3)? ");
        int diff = Convert.ToInt16(Console.ReadLine());
        questions[choice] = new Question(question, answer, diff);
        
    }

    public void giveQuiz(){
        numCorrect = 0;
        foreach(Question question in questions){
            Console.Write(question.questionText + " ");
            string response = Console.ReadLine().ToLower();
            if(response.ToLower() == question.answer){
                Console.WriteLine("Correct!");
                numCorrect++;
            }
            else{
                Console.WriteLine("Incorrect!");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Your score is {0:0.##}%", ((float)numCorrect/questions.Count) * 100);
    }

}