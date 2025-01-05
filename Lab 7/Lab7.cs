using System;
class Lab7{
    public static void Main(String[] args){
        Calculator calculator = new Calculator();
        bool finished = false;

        while(!finished){
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Please choose an option: ");

            string choice = Console.ReadLine();
            switch(choice){
                case "1": 
                    getInput(calculator.add);
                    break;
                case "2":
                    getInput(calculator.subtract);
                    break;
                case "3":
                    getInput(calculator.multiply);
                    break;
                case "4":
                    getInput(calculator.divide);
                    break;
                case "0":
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    static void getInput(Func<float, float, float> operation){
        Console.Write("Please enter first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine(operation(a,b));
    }
}