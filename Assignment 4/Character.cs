using System;
abstract class Character : ISpeak
{
    private string description = null;
    private string whoami = null;
    public Character(string d, string w)
    {
        description = d;
        whoami = w;
    }
    public string getDescription()
    {
        return description;
    }
    public bool guessWho(string guess)
    {
        string lowerGuess = guess.ToLower();
        string rightAns = whoami.ToLower();
        return (lowerGuess.Equals(rightAns));
    }
    public string getCharacterName()
    {
        return whoami;
    }
    public abstract string greeting();
    public abstract string getInformation();
    public abstract string sayGoodbye();
}