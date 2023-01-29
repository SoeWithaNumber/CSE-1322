using System;
using System.Collections.Generic;

public class Poker{
    private PlayingCards deck = new PlayingCards();
    private List<string> hand1 = new List<string>();
    private List<string> hand2 = new List<string>();

    public Poker(){
        deck.Shuffle();
        dealHands();
    }
    public Poker(List<string> hand1, List<string> hand2){
        this.hand1 = hand1;
        this.hand2 = hand2;
    }

    public void dealHands(){
        for(int i=0; i < 5; i++){
            hand1.Add(deck.getNextCard());
            hand2.Add(deck.getNextCard());
        }
    }

    public void showHand(int hand){
        if(hand == 1){
            Console.WriteLine(string.Join(", ", hand1));
        }
        else{
            Console.WriteLine(string.Join(", ", hand2));
        }
    }

    private int[] countSuite(List<string> hand){
        int[] output = new int[4];
        foreach(string card in hand){
            string suit = card.Split(' ')[2].ToLower();
            switch(suit){
                case "clubs":
                    output[0]++;
                    break;
                case "diamonds":
                    output[1]++;
                    break;
                case "hearts":
                    output[2]++;
                    break;
                case "spades":
                    output[3]++;
                    break;
            }
        }
            return output;
    }

    private int[] countValues(List<string> hand){
        int[] output = new int[14];
        foreach(string card in hand){
            string value = card.Split(' ')[0];
            switch(value){
                case "A":
                    output[1]++;
                    break;
                case "J":
                    output[11]++;
                    break;
                case "Q":
                    output[12]++;
                    break;
                case "K":
                    output[13]++;
                    break;
                default:
                    int numericalValue = Convert.ToInt32(value);
                    output[numericalValue]++;
                    break;
            }
        }
        return output;
    }

    private int numPairs(int[] values){
        int pairs = 0;
        foreach(int value in values){
            pairs += value == 2 ? 1 : 0;
        }
        return pairs;
    }

    private int threeOfAKind(int[] values)
    {
        for(int i=0; i<values.Length; i++){
            if(values[i] == 3) {return i;}
        }
        return 0;
    }

    private int fourOfAKind(int[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == 4) {return i;}
        }
        return 0;
    }

    private bool fullHouse(int[] values){
        if(numPairs(values) == 1 && threeOfAKind(values) > 0){
            return true;
        }
        return false;
    }

    private bool straight(int[] values){

        if(values[1] == 1 && values[10] == 1 && values[11] == 1 && values[12] == 1 && values[13] == 1){
            return true;
        }

        int combo = 0;
        foreach(int value in values){
            if(value > 1){return false;}
            else if(value == 1){combo++;}
            else{combo = 0;}
            if(combo == 5){return true;}
        }
        return false;
    }

    private bool flush(int[] suits){
        foreach(int numOfSuits in suits){
            if(numOfSuits == 5){return true;}
        }
        return false;
    }

    private bool straightFlush(int[] values, int[] suits){
        if(straight(values) && flush(suits)){
            return true;
        }
        return false;
    }

    private bool royalFlush(int[] values, int[] suits){
        if (flush(suits) && values[1] == 1 && values[10] == 1 && values[11] == 1 && values[12] == 1 && values[13] == 1)
        {
            return true;
        }
        return false;
    }

    public string scoreHand(int hand){
        int[] values, suits;
        if(hand == 1){
            values = countValues(hand1);
            suits = countSuite(hand1);
        }
        else{
            values = countValues(hand2);
            suits = countSuite(hand2);
        }

        if(royalFlush(values, suits)){return "Royal flush";}
        else if(straightFlush(values, suits)){return "Straight flush";}
        else if(fourOfAKind(values) > 0){return "Four of a kind";}
        else if(fullHouse(values)){return "Full house";}
        else if(flush(suits)){return "Flush";}
        else if(straight(values)){return "Straight";}
        else if(threeOfAKind(values) > 0){return "Three of a kind";}
        else if(numPairs(values) == 2){return "Two pair";}
        else if(numPairs(values) == 1){ return "Pair";}
        else{return "High card";}
    }
}