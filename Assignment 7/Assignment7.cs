using System;
using System.Threading;
class Assignment7{
    public static void Main(String[] args){
        StatisticGradeBook gb = new StatisticGradeBook("Assignment7-Spreadsheet.csv");
        Thread gradebookThread = new Thread(gb.Run);
        gradebookThread.Start();

        Console.Write("What student would you like to see grades for?");
        string input = Console.ReadLine();
        gb.getStudentGrade(input);
    }
}