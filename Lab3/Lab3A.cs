using System;
class Lab3A{
    public static void Main(String[] args){
        Quiz quiz = new Quiz();
        
        bool finished = false;

        while(!finished){

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add question");
            Console.WriteLine("2. Remove a question");
            Console.WriteLine("3. Modify a question");
            Console.WriteLine("4. Take the quiz");
            Console.WriteLine("5. Quit");

            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    quiz.addQuestion();
                    break;
                case "2":
                    quiz.removeQuestion();
                    break;
                case "3":
                    quiz.modifyQuestion();
                    break;
                case "4":
                    quiz.giveQuiz();
                    break;
                case "5":
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}