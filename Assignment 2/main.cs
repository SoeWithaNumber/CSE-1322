using System;
using System.Collections.Generic;
class main{
    public static void Main(String[] args){
        List<Lot> auction = new List<Lot>();
        mainMenu(auction);
    }
    static Lot getNextLot(List<Lot> lots){
        Lot nextLot = lots[0];
        lots.RemoveAt(0);
        return nextLot;
    }
    static void addItem(List<Lot> lots){
        Console.Write("What is the description of the item? ");
        string description = Console.ReadLine();
        Console.Write("What is the starting bid of the item? ");
        int startingBid = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bidding increment of the item? ");
        int bidIncrement = Convert.ToInt32(Console.ReadLine());
        lots.Add(new Lot(description, startingBid, bidIncrement));
    }
    static void bid(Lot lot){
        Console.WriteLine("Minimum bid: ${0}", lot.nextBid());
        Console.Write("How much would you like to bid? ");
        while(true){
            int bidAmount = Convert.ToInt32(Console.ReadLine());
            if(bidAmount < lot.nextBid()){
                Console.Write("Below minimum bid. Try again: ");
                continue;
            }
            lot.currentBid = bidAmount;
            return;
        }
    }
    static void markSold(Lot lot){
        lot.markSold();
    }
    static void mainMenu(List<Lot> lots){
        bool finished = false;
        Lot currentLot = null;
        while(!finished){
            bool activeLot;
            if(currentLot == null || currentLot.description == "Unknown item"){activeLot = false;}
            else{activeLot = true;}

            Console.WriteLine(activeLot ? currentLot.ToString() : "We are not currently bidding");

            Console.WriteLine("1. Add lot to auction");
            Console.WriteLine("2. Start bidding on next lot");
            Console.WriteLine("3. Bid on current lot");
            Console.WriteLine("4. Mark current lot sold");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    addItem(lots);
                    break;
                case "2":
                    if(lots.Count == 0){Console.WriteLine("There is nothing to bid on, add an item first");}
                    else if(currentLot != null && !currentLot.sold){Console.WriteLine("You must mark the current lot as sold before bringing up the next lot");}
                    else{currentLot = getNextLot(lots);}
                    break;
                case "3":
                    if(!activeLot || currentLot.sold){Console.WriteLine("You must first bring a lot up before bidding");}
                    else{bid(currentLot);}
                    break;
                case "4":
                    if(!activeLot){Console.WriteLine("You must first bring up a lot for bidding");}
                    else{markSold(currentLot);}
                    break;
                case "5":
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }
    }
}