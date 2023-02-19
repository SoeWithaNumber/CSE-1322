using System;
class Move : Customer
{
    private string name;
    private string previousState;
    public Move(string name, string previousState) : base('c')
    {
        this.name = name;
        this.previousState = previousState;
    }
    public override string getCustomerInfo()
    {
        return String.Format("Moved from {2}. Ticket number: {0}. Name: {1}", getTicketNumber(), name, previousState);
    }
}