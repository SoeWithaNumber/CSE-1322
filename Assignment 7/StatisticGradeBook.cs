using System;
using System.Collections.Generic;
class StatisticGradeBook : GradeBook{
    public StatisticGradeBook(string filename) : base(filename){
        
    }
    public void Run(){
        int studentNumber = 0;
        for(LinkedListNode<Student> studentNode = students.First; studentNode != null; studentNode = studentNode.Next)
        {
            if(studentNumber%100 == 0){
                Console.WriteLine("Calculating grades {0} of {1}", studentNumber, students.Count);
            }
            //I know technically I'm supposed to call quizAvg and hwAvg too, but overallAvg calls both of them anyways.
            studentNode.Value.calcOverallAvg();
            studentNumber++;
        }
    }
}