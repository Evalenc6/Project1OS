using System;
using System.Threading;
class BasicThread{
    
    protected List<Thread> ThreadList = [];
    static void Main(){

    }
    
    public void CreateThreads(int numOfThreads){
        for(int i = 0; i<numOfThreads; i++){
            ThreadList.Add(new Thread(new ThreadStart(startBuyStuff)));
            Console.Write("Added Thread" + i +  ": " +ThreadList[i]);
        }

        return;
    }

    public void StartThreads(){
        foreach(Thread t in ThreadList){
            Console.Write("I am getting 60 dollars from the bank");
        }
    }
    public void StartBuyStuff(){
        BuyStuff(50);
    }
    public int BuyStuff(int cost){
        Console.Write("Taking " + cost + " out to get some of my stuff done ");
        return cost;
    }
    

}