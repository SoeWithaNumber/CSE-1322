using System;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
class Assignment6{
    public static void Main(String[] args){
        bool finished = false;
        while(!finished){
            float currentPrice = getDollarPrice(getData());
            Console.WriteLine("One Bitcoin is currently worth ${0}", currentPrice);
            Console.WriteLine("1. Buy Bitcoin");
            Console.WriteLine("2. See everyone's current value in USD");
            Console.WriteLine("3. See on person's gain/loss");
            Console.WriteLine("4. Quit");
            string response = Console.ReadLine();

            switch(response){
                case "1":
                    buyBitcoin(currentPrice);
                    break;
                case "2":
                    getCurrentValue(currentPrice);
                    break;
                case "3":
                    personMenu(currentPrice);
                    break;
                case "4":
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }


    }

    //Data handling and retrieval

    public static List<string> getData(){
        using(TcpClient client = new TcpClient("api.coindesk.com", 80))
        using(NetworkStream ns = client.GetStream())
        using(StreamReader socketRead = new StreamReader(ns))
        using(StreamWriter socketWrite = new StreamWriter(ns))
        //These using statements pretty much allow me to create the streams, then after the block is finished it will automatically close and dispose of them
        {
            socketWrite.Write("GET http://api.coindesk.com/v1/bpi/currentprice.json HTTP/1.0\n\n");
            socketWrite.Flush();

            List<string> data = new List<string>();
            while (!socketRead.EndOfStream)
            {
                data.Add(socketRead.ReadLine());
            }
            return data;
        }
    }

    public static float getDollarPrice(List<string> lines)
    {
        bool header = true;
        String json = "";
        foreach (string line in lines)
        {
            if (line.Equals(""))
            {
                header = false;
                continue;
            }
            if (header == false)
            {
                json = line;
                break;
            }
        }
        //Console.WriteLine("Json: "+json);
        String[] jsonParts = json.Split(":");
        String priceLine = jsonParts[19];
        String justPrice = priceLine.Replace("},\"GBP\"", "");
        float price = Convert.ToSingle(justPrice);
        return price;
    }

    public static void buyBitcoin(float price){
        using(StreamWriter outputStream = new StreamWriter("clientBC.txt"))
        using(StreamReader investmentsStream = new StreamReader("initialInvestmentUSD.txt")){
            while(!investmentsStream.EndOfStream){
                string currentLine = investmentsStream.ReadLine();
                string name = currentLine.Split(":")[0];
                float investment = float.Parse(currentLine.Split(':')[1]);
                outputStream.WriteLine("{0}:{1}", name, investment/price);
            }
            outputStream.Flush();
        }
        
    }

    public static void getCurrentValue(float price){
        using(StreamReader balanceStream = new StreamReader("clientBC.txt")){
            while(!balanceStream.EndOfStream){
                string currentLine = balanceStream.ReadLine();
                string name = currentLine.Split(":")[0];
                float balance = float.Parse(currentLine.Split(':')[1]);
                Console.WriteLine("{0}:{1}", name, balance*price);
            }
        }
    }

    public static float getPersonFromFile(string nameToBeFound, string filename){
        using(StreamReader fileStream = new StreamReader(filename)){
            while(!fileStream.EndOfStream){
                string currentLine = fileStream.ReadLine();
                string name = currentLine.Split(":")[0];
                float balance = float.Parse(currentLine.Split(':')[1]);
                if(name.ToLower() == nameToBeFound.ToLower()){
                    return balance;
                }
            }
            
            throw new PersonNotFoundException("Unable to find " + nameToBeFound);
        }
    }

    //Helper
    public static void personMenu(float price){
        Console.Write("Who would you like to know about? ");
        string name = Console.ReadLine();
        float originalInvestment, currentBalance, currentBTC;
        try{
            originalInvestment = getPersonFromFile(name, "initialInvestmentUSD.txt");
            currentBTC = getPersonFromFile(name, "clientBC.txt");
        }
        catch(PersonNotFoundException e){
            Console.WriteLine(e.Message);
            return;
        }
        currentBalance = currentBTC * price;
        Console.WriteLine(name);
        Console.WriteLine("Original investment: ${0}", originalInvestment);
        Console.WriteLine("Bitcoins: {0}", currentBTC);
        Console.WriteLine("Current Value: ${0}", currentBalance);
        Console.WriteLine("Change in value: ${0}", originalInvestment - currentBalance);
    }
}

class PersonNotFoundException : Exception{
    public PersonNotFoundException(string message):base(message){
        
    }
}