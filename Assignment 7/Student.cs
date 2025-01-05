using System;
class Student{
    private int[] quizScores = new int[10];
    private int[] hwScores = new int[10];
    private int midtermScore;
    private int finalScore;
    private double quizAvg;
    private double hwAvg;
    private double overallAvg;
    private string name;
    private int id;


    public Student(string input){
        string[] data = input.Split(',');
        name = data[0];
        Console.WriteLine(data[1]);
        id = Convert.ToInt32(data[1]);

        for(int i = 2; i<12; i++){
            quizScores[i-2] = Convert.ToInt32(data[i]);
        }
        //Array.Copy(input, 2, quizScores, 0, 10);
        //Array.Copy(input, 13, hwScores, 0, 10);
        for (int i = 13; i < 22; i++)
        {
            hwScores[i - 13] = Convert.ToInt32(data[i]);
        }
        midtermScore = Convert.ToInt32(data[22]);
        finalScore = Convert.ToInt32(data[23]);

    }

    public string getName(){
        return name;
    }
    public int getId(){
        return id;
    }
    public void calcQuizAverage(){
        double avg = 0;
        int smallest = quizScores[0];
        foreach(int score in quizScores){
            smallest = score < smallest ? score : smallest;
            avg += score;
        }
        avg -= smallest;
        quizAvg = avg/(quizScores.Length-1);
    }
    public void calcHwAverage()
    {
        double avg = 0;
        int smallest = hwScores[0];
        foreach (int score in hwScores)
        {
            smallest = score < smallest ? score : smallest;
            avg += score;
        }
        avg -= smallest;
        hwAvg = (double)(avg/(hwScores.Length-1));
    }

    public void calcOverallAvg(){
        calcQuizAverage();
        calcHwAverage();

        double weightedQuiz = quizAvg*0.4;
        double weightedHw = hwAvg*0.1;
        double weightedMidterm = midtermScore*0.2;
        double weightedFinal = finalScore*0.3;

        overallAvg = weightedQuiz + weightedHw + weightedMidterm + weightedFinal;

    }

    public void getGrade(){
        for(int i = 0; i < quizScores.Length; i++){
            Console.WriteLine("Quiz {0} score: {1}", i+1, quizScores[i]);
        }
        Console.WriteLine("Quiz average: {0}", quizAvg);
        for (int i = 0; i < hwScores.Length; i++)
        {
            Console.WriteLine("Hw {0} score: {1}", i + 1, hwScores[i]);
        }
        Console.WriteLine("HW average: {0}", hwAvg);
        Console.WriteLine("Midterm: {0}", midtermScore);
        Console.WriteLine("Final: {0}", finalScore);
        Console.WriteLine("Overall average: {0}", overallAvg);
    }
}