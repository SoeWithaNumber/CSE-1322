using System;
class Assignment4{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Room newRoom = new Room();
            Console.WriteLine("If you know who it is guess, if you don't type hint");
        String theGuess = Console.ReadLine();
            if (theGuess.Equals("hint"))
            {
                newRoom.askForSecret();
                Console.WriteLine("OK, so who is it?");
                String finalGuess = Console.ReadLine();
                newRoom.guessWho(finalGuess);
            }
            else
            {
                newRoom.guessWho(theGuess);
            }
        }
    }
}