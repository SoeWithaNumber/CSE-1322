using System;
class Checking : Account{
    public Checking(double balance) : base(balance){}
    public Checking() : base(){}

    public override void withdraw(double deduction){
        if(balance - deduction < 0){
            Console.WriteLine("Charging an overdraft fee of $20 because account is below $0");
            balance -= deduction + 20;
        }
        else{
            balance -= deduction;
        }
    }
}