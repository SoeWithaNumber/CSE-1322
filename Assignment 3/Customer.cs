using System;
abstract class Customer{
    private static int nextANum = 1;
    private static int nextBNum = 1;
    private static int nextCNum = 1;
    private static int nextDNum = 1;
    private char ticketType;
    private int ticketNumber;
    public Customer(){
        ticketType = 'X';
        ticketNumber = 0;
    }
    public Customer(char ticketType){
        switch(Char.ToLower(ticketType)){
            case 'a':
                this.ticketType = 'A';
                ticketNumber = nextANum++;
                break;
            case 'b':
                this.ticketType = 'B';
                ticketNumber = nextBNum++;
                break;
            case 'c':
                this.ticketType = 'C';
                ticketNumber = nextCNum++;
                break;
            case 'd':
                this.ticketType = 'D';
                ticketNumber = nextDNum++;
                break;
            default:
                Console.WriteLine("Error, letter must be A, B, C, or D");
                ticketType = 'X';
                ticketNumber = 0;
                break;
        }
    }
    protected string getTicketNumber()
    {
        return String.Format("{0}{1}", ticketType, ticketNumber);
    }
    public abstract string getCustomerInfo();
}