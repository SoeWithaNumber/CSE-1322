using System;
class Lab12{
    public static void Main(String[] args){
        BlueRayCollection myCollection = new BlueRayCollection();
        
        bool finished = false;
        while(!finished){
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Add movie");
            Console.WriteLine("2. Show all");
            string input = Console.ReadLine();
            switch(input){
                case "0":
                    finished = true;
                    break;
                case "1":
                    takeInput(myCollection);
                    break;
                case "2":
                    myCollection.showAll();
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

    }
    public static void takeInput(BlueRayCollection collection){
        Console.Write("What is the title: ");
        string title = Console.ReadLine();
        Console.Write("Who is the director: ");
        string director = Console.ReadLine();
        Console.Write("What is the year of release: ");
        int yoy = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the cost: ");
        double cost = Double.Parse(Console.ReadLine());
        collection.add(title, director, yoy, cost);
    }
}