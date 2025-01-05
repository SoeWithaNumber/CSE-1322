using System;
using System.Text.RegularExpressions;
class Lab9{
    public static void Main(String[] args){
        
        Console.WriteLine("Enter time 1 in HH:MM:SS format");
        string time1string = Console.ReadLine();
        Console.WriteLine("Enter time 2 in HH:MM:SS format");
        string time2string = Console.ReadLine();

        int time1int;
        int time2int;
        try{
            time1int = convertTimeToInt(time1string);
            time2int = convertTimeToInt(time2string);
        }
        catch(InvalidCastException e){
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine("Difference in seconds: {0}", Math.Abs(time1int - time2int));

    }
    public static int convertTimeToInt(string time){
        string[] timeSplit = time.Split(':',3);
        Regex expression = new Regex(@"^\d{2}:\d{2}:\d{2}$");
        
        if(!expression.Match(time).Success){
            throw new InvalidTimeException("Invalid time format");
        }
        
        int hours, minutes, seconds;

        hours = Convert.ToInt32(timeSplit[0]);
        minutes = Convert.ToInt32(timeSplit[1]);
        seconds = Convert.ToInt32(timeSplit[2]);
        if(hours > 23 || hours < 0){
            throw new InvalidTimeException("Hour not valid");
        }

        if (minutes > 59 || minutes < 0){
            throw new InvalidTimeException("Minute not valid");
        }

        if (seconds > 59 || seconds < 0){
            throw new InvalidTimeException("Second not valid");
        }
        
        
        return (hours*60*60) + (minutes*60) + seconds;

    }
}