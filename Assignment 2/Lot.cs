using System;
class Lot{
    private static int NEXT_LOT_NUMBER = 1001;
    public int lotNumber{get; private set;}
    public string description{get; private set;}
    public int bidIncrement{get; set;}
    public int currentBid{private get; set;}
    public bool sold{get; private set;}
    public Lot(){
        lotNumber = NEXT_LOT_NUMBER++;
        description = "Unknown item";
        currentBid = 0;
        bidIncrement = 0;
        sold = false;
    }
    public Lot(string description, int startingBid, int bidIncrement){
        lotNumber = NEXT_LOT_NUMBER++;
        this.description = description;
        this.currentBid = startingBid;
        this.bidIncrement = bidIncrement;
        sold = false;
    }
    public void markSold(){
        sold = true;
    }
    public int nextBid(){
        return bidIncrement + currentBid;
    }
    public override string ToString(){
        if(!sold){
            return String.Format("Lot {0}. {1} current bid ${2} minimum bid ${3}", lotNumber, description, currentBid, nextBid());
        }
        return String.Format("Lot {0}. {1} was sold for {2}", lotNumber, description, currentBid);
    }

}