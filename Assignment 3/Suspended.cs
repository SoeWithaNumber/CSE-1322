using System;
class Suspended : Customer
{
    private string name;
    private string violation;
    public Suspended(string name, string violation) : base('d')
    {
        this.name = name;
        this.violation = violation;
    }
    public override string getCustomerInfo()
    {
        return String.Format("Violation: {0}.  Ticket number {1}. Name: {2}", violation, getTicketNumber(), name);
    }
}