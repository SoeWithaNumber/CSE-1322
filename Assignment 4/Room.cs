using System;
class Room
{
    static int nextRoomNum = 1;
    int roomNum;
    Character personInRoom;
    public Room()
    {
        roomNum = nextRoomNum++;
        if (roomNum == 1)
        {
            personInRoom = new CharacterOne();
        }
        else if (roomNum == 2)
        {
            personInRoom = new CharacterTwo();
        }
        else
        {
            personInRoom = new CharacterThree();
        }
        Console.WriteLine("Welcome to room number "+roomNum);
        Console.WriteLine("In here we have a fascinating character from popular movies...");
        Console.WriteLine("Movie character, please tell us a little about yourself...");
        Console.WriteLine();
        Console.WriteLine(""+personInRoom.getDescription());
        Console.WriteLine(""+personInRoom.greeting());
        Console.WriteLine();
    }
    public void askForSecret()
    {
        Console.WriteLine("Okay, movie character tell me a secret");
        Console.WriteLine();
        Console.WriteLine(" "+personInRoom.getInformation());
        Console.WriteLine();
    }
    public void sayGoodbye()
    {
        Console.WriteLine("Thank you "+personInRoom.getCharacterName());
        Console.WriteLine();
        Console.WriteLine(""+personInRoom.sayGoodbye());
        Console.WriteLine();
    }
    public void guessWho(string nameGuess)
    {
        if (personInRoom.guessWho(nameGuess))
        {
            Console.WriteLine("Congratulations you guessed "+nameGuess+" correctly.");
            Console.WriteLine(""+personInRoom.getCharacterName()+" says "+personInRoom.sayGoodbye());
        }
        else
        {
            Console.WriteLine("I'm sorry it's not "+nameGuess+" it was "+personInRoom.getCharacterName());
            Console.WriteLine(""+personInRoom.getCharacterName()+" says "+personInRoom.sayGoodbye());
        }
    }
}
