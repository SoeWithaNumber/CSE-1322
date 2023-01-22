using System;
class Lab2A{
    public static void Main(String[] args){
        StockItem milk = new StockItem("1 Gallon of Milk", 15, 3.60);
        StockItem bread = new StockItem("1 Loaf of Bread", 30, 1.98);

        bool finished = false;
        
        while(!finished){
            Console.WriteLine("1. Sell 1 milk");
            Console.WriteLine("2. Sell 1 bread");
            Console.WriteLine("3. Change the price of milk");
            Console.WriteLine("4. Change the price of bread");
            Console.WriteLine("5. Add milk to inventory");
            Console.WriteLine("6. Add bread to inventory");
            Console.WriteLine("7. See inventory");
            Console.WriteLine("8. Quit");

            int input = Convert.ToInt32(Console.ReadLine());

            switch(input){
                case 1:
                    Console.WriteLine("Lowered milk stock by 1");
                    milk.lowerStock(1);
                    break;
                case 2: 
                    Console.WriteLine("Lowered bread stock by 1");
                    bread.lowerStock(1);
                    break;
                case 3:
                    Console.Write("New price for milk: ");
                    double newMilkPrice = Convert.ToDouble(Console.ReadLine());
                    milk.setPrice(newMilkPrice);
                    break;
                case 4:
                    Console.Write("New price for bread: ");
                    double newBreadPrice = Convert.ToDouble(Console.ReadLine());
                    bread.setPrice(newBreadPrice);
                    break;
                case 5:
                    Console.Write("How much milk? ");
                    int addedMilk = Convert.ToInt32(Console.ReadLine());
                    milk.raiseStock(addedMilk);
                    break;
                case 6:
                    Console.Write("How much bread? ");
                    int addedBread = Convert.ToInt32(Console.ReadLine());
                    bread.raiseStock(addedBread);
                    break;
                case 7:
                    Console.WriteLine(milk);
                    Console.WriteLine(bread);
                    break;
                case 8:
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
            Console.WriteLine();

        }
    }
}