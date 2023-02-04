using System;
abstract class Account{
    public static int NEXT_ACC_NUMBER = 1001;
    public int accountNumber {get; private set;}

    public double balance{get; set;}
    public Account(double balance){
        accountNumber = NEXT_ACC_NUMBER++;
        this.balance = balance;
    }
    public Account(){
        accountNumber = NEXT_ACC_NUMBER++;
        this.balance = 0;
    }

    public virtual void withdraw(double deduction){
        balance -= deduction;
    }
    public virtual void deposit(double addition){
        balance += addition;
    }
}