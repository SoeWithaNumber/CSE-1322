using System;
class Savings : Account{
    private int deposits = 0;
    public Savings(double balance) : base(balance){}
    public Savings() : base(){}
    public override void withdraw(double deduction){
        if (balance - deduction < 500){
            Console.WriteLine("Charging an overdraft fee of $10");
            balance -= deduction + 10;
        }
        else{
            balance -= deduction;
        }
    }
    public override void deposit(double addition){
        Console.WriteLine("This is deposit {0} to this account", ++deposits);
        if(deposits >= 6){
            Console.WriteLine("Charging a fee of $10");
            balance += addition - 10;
        }
        else{
            balance += addition;
        }
    }
    public void interest(){
        double earnedInInterest = balance * 0.015;
        Console.WriteLine("Customer gained ${0:0.##} in interest", earnedInInterest);
        balance += earnedInInterest;
    }
}