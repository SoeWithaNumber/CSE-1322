using System;
class CharacterTwo : Character
{
    public CharacterTwo() : base("I am originally from a classic comic strip series. I have a single curly hair and an iconic yellow shirt with a jagged black line.", "Charlie Brown")
    {

    }

    public override string greeting()
    {
        return "Hi there!";
    }
    public override string getInformation()
    {
        return "Good grief!";
    }
    public override string sayGoodbye()
    {
        return "Bye!";
    }
}
