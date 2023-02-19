using System;
using System.Collections.Generic;
class Assignment3{
    public static void Main(String[] args){
        List<Customer> customers = new List<Customer>();
        menu(customers);
    }
    private static void menu(List<Customer> customers){
        bool finished = false;
        while(!finished){
            Console.WriteLine("1. Take test for new license");
            Console.WriteLine("2. Renew existing license");
            Console.WriteLine("3. Move from out of state");
            Console.WriteLine("4. Answer citation/suspended license");
            Console.WriteLine("5. See current queue");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();

            switch(choice){
                case "1":
                    testChoice(customers);
                    break;
                case "2":
                    renewChoice(customers);
                    break;
                case "3":
                    moveChoice(customers);
                    break;
                case "4":
                    violationChoice(customers);
                    break;
                case "5":
                    customers.ForEach(customer => Console.WriteLine(customer.getCustomerInfo()));
                    break;
                case "6":
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    private static void testChoice(List<Customer> customers){
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("What is your date of birth? ");
        string dob = Console.ReadLine();
        customers.Add(new NewTest(name, dob));
    }
    private static void renewChoice(List<Customer> customers)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        customers.Add(new Renew(name));
    }
    private static void moveChoice(List<Customer> customers)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("What state are you moving from? ");
        string state = Console.ReadLine();
        customers.Add(new Move(name, state));
    }
    private static void violationChoice(List<Customer> customers)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("What violation did you commit? ");
        string violation = Console.ReadLine();
        customers.Add(new Suspended(name, violation));
    }
}