using System;

public class Question{

    public Question(string questionText, string answer, int difficulty){
        this.questionText = questionText;
        this.answer = answer.ToLower();
        this.difficulty = difficulty;
    }
    public string questionText{get; set;}
    public string answer{get; set;}
    public int difficulty{get; set;}
}