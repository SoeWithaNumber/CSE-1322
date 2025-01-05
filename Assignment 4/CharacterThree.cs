using System;
class CharacterThree : Character
{
    public CharacterThree() : base("I live in Quahog Rhode island with my wife and 3 kids. I'm fat with glasses, a white shirt, and green pants.", "Peter Griffin")
    {

    }
    public override string greeting()

    {
        return "Lois? Where are we?";
    }
    public override string getInformation()
    {
        return "Lois, hey Lois. This reminds me of the time I was in my CS class *queue cutaway gag*";
    }
    public override string sayGoodbye()
    {
        return "Lois I wanna go home";
    }
}
