using System;
using System.IO;
using System.Collections.Generic;
class Lab10{
    public static void Main(String[] args){
        Console.Write("Enter name of first file: ");
        string file1Name = Console.ReadLine();
        Console.Write("Enter name of second file: ");
        string file2Name = Console.ReadLine();
        StreamReader file1;
        StreamReader file2;

        try{
            file1 = new StreamReader(file1Name);
            file2 = new StreamReader(file2Name);
        }
        catch(FileNotFoundException e){
            Console.WriteLine("Couldn't find files!");
            return;
        }

        List<string> changes = new List<string>();
        int currentLine = 1;

        while(!file1.EndOfStream){
            if(file2.EndOfStream){
                Console.WriteLine("Files have different numbers of lines");
                return;
            }
            string line1 = file1.ReadLine();
            string line2 = file2.ReadLine();
            if(line1 != line2){
                string changeToAdd = String.Format("Line {0}\n< {1}\n> {2}", currentLine, line1, line2);
                changes.Add(changeToAdd);
            }
            currentLine++;
        }
        if(!file2.EndOfStream){
            Console.WriteLine("Files have different numbers of lines");
            return;
        }
        file1.Close();
        file2.Close();

        if(changes.Count == 0){
            Console.WriteLine("No differences");
            return;
        }

        foreach(string change in changes){
            Console.WriteLine(change);
        }
    }
}