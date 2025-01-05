using System;
using System.Threading;
class Baby{
    private int time;
    private string name;
    private static readonly Random RND = new Random();
    public Baby(string name){
        //For whatever reason, creating the random object and calling rnd.next(5000) in the constructor resulted in the same random number for all baby objects
        //So I made the random object static so the random values are always pulled from the same object, ensuring there are no duplicate numbers
        time = RND.Next(5000);
        this.name = name;
    }
    public void Run(){
        Console.WriteLine("My name is {0} and I am going to sleep for {1}ms", name, time);
        
        try{
            Thread.Sleep(time);
        }
        catch(ThreadInterruptedException e){
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("My name is {0}, I am awake, feed me!", name);
    }
}