using System;
class CharacterOne : Character{
    public CharacterOne() : base("I live at 308 Arroyo Lane, Albuquerque, New Mexico, 87104. I have terminal lung cancer and in order to pay for the treatment, I created a drug empire", "Walter White"){

    }

    public override string greeting()
    {
        return "Hello";
    }
    public override string getInformation()
    {
        return "I have the moniker \"Heisenberg\"";
    }
    public override string sayGoodbye()
    {
        return "Goodbye";
    }
}
