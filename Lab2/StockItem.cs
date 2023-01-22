using System;
public class StockItem{
    private static int nextId = 0;
    private string description;
    private int id, stock;
    private double price;

    public StockItem(){
        this.id = nextId++;
        this.description = "";
        this.stock = 0;
        this.price = 0f;
    }
    public StockItem(string description, int stock, double price){
        this.id = nextId++;
        this.description = description;
        this.stock = stock;
        this.price = Math.Round(price, 2);
    }


    public override string ToString()
    {
        return String.Format("Item number: {0} is {1}. It has a price of {2} and there are {3} in stock.", id, description, price, stock);
    }
    public string getDescription(){
        return description;
    }
    public double getPrice(){
        return price;
    }
    public int getStock(){
        return stock;
    }
    public int getId(){
        return id;
    }
    public void setPrice(double newPrice){
        if(newPrice < 0){
            Console.WriteLine("Cannot set price below zero");
            return;
        }
        price = Math.Round(newPrice, 2);
    }
    public void lowerStock(int quantity){
        if(stock - quantity < 0){
            Console.WriteLine("Cannot lower stock to below zero");
            return;
        }
        stock -= quantity;
    }
    public void raiseStock(int quantity){
        stock =+ quantity;
    }

}