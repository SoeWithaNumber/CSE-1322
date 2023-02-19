using System;
class NewTest : Customer{
    private string name;
    private string dob;
    public NewTest(string name, string dob) : base('a'){
        this.name = name;
        this.dob = dob;
    }
    public override string getCustomerInfo(){
        return String.Format("New Driver's License. Ticket number {0}. Name: {1} DOB: {2}", getTicketNumber(), name, dob);
    }
}