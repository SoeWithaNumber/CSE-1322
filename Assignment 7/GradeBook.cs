using System;
using System.Collections.Generic;
using System.IO;
class GradeBook{
    protected LinkedList<Student> students = new LinkedList<Student>();
    public GradeBook(string filename){
        try{
            StreamReader studentData;
            studentData = new StreamReader(filename);
            while(!studentData.EndOfStream){
                students.AddLast(new Student(studentData.ReadLine()));
            }
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
    public Student getStudent(string name){
        for(LinkedListNode<Student> studentNode = students.First; studentNode!=null; studentNode=studentNode.Next){
            if(studentNode.Value.getName() == name){
                return studentNode.Value;
            }
        }
        return null;
    }
    public void getStudentGrade(string name){
        Student? foundStudent = getStudent(name);
        if(foundStudent == null){
            Console.WriteLine("Unable to find student");
            return;
        }
        foundStudent.getGrade();
    }
    public LinkedList<string> getAllStudentNames(){
        LinkedList<string> studentNames = new LinkedList<string>();
        for(LinkedListNode<Student> studentNode = students.First; studentNode != null; studentNode = studentNode.Next)
        {
            studentNames.AddLast(studentNode.Value.getName());
        }
        return studentNames;
    }
}