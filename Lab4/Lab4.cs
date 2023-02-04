using System;
class Lab4{
    public static void Main(String[] args){
        Checking checkingAcc = new Checking();
        Savings savingsAcc = new Savings();

        bool finished = false;

        while(!finished){
            Console.WriteLine("1. Withdraw from checking");
            Console.WriteLine("2. Withdraw from savings");
            Console.WriteLine("3. Deposit to checking");
            Console.WriteLine("4. Deposit to savings");
            Console.WriteLine("5. Balance of checking");
            Console.WriteLine("6. Balance of savings");
            Console.WriteLine("7. Award interest to savings now");
            Console.WriteLine("8. Quit");

            string input = Console.ReadLine();

            switch(input){
                case "1":
                    Console.Write("How much would you like to withdraw from checking? ");
                    double checkingWithdraw = Convert.ToDouble(Console.ReadLine());
                    checkingAcc.withdraw(checkingWithdraw);
                    break;
                case "2":
                    Console.Write("How much would you like to withdraw from savings? ");
                    double savingsWithdraw = Convert.ToDouble(Console.ReadLine());
                    savingsAcc.withdraw(savingsWithdraw);
                    break;
                case "3":
                    Console.Write("How much would you like to deposit to checking? ");
                    double checkingDeposit = Convert.ToDouble(Console.ReadLine());
                    checkingAcc.deposit(checkingDeposit);
                    break;
                case "4":
                    Console.Write("How much would you like to deposit to savings? ");
                    double savingsDeposit = Convert.ToDouble(Console.ReadLine());
                    savingsAcc.deposit(savingsDeposit);
                    break;
                case "5":
                    Console.WriteLine("The balance in account {0} is ${1:0.##}", checkingAcc.accountNumber, checkingAcc.balance);
                    break;
                case "6":
                    Console.WriteLine("The balance in account {0} is ${1:0.##}", savingsAcc.accountNumber, savingsAcc.balance);
                    break;
                case "7":
                    savingsAcc.interest();
                    break;
                case "8":
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

    }
}