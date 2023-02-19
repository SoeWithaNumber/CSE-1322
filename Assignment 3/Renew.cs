using System;
class Renew : Customer
{
    private string name;
    public Renew(string name) : base('b')
    {
        this.name = name;
    }
    public override string getCustomerInfo()
    {
        return String.Format("Renewal license. Ticket number: {0}. Name: {1}", getTicketNumber(), name);
    }
}