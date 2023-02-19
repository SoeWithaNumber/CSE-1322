using System;
class Lab6{
    public static void Main(String[] args){
        FibIteration iteration = new FibIteration();
        FibFormula formula = new FibFormula();
        Console.Write("Enter the number you want to find the Fibonacci series for: ");
        int index = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fib of {0} by iteration is {1}", index, iteration.calculateFib(index));
        Console.WriteLine("Fib of {0} by formula is {1}", index, formula.calculateFib(index));
    }
}