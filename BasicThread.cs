using System;
using System.Threading;
class BasicThread{
    
    protected List<Thread> ThreadList = new List<Thread>();
 
    public void CreateThreads(int numOfThreads){
        for(int i = 0; i<numOfThreads; i++){
            ThreadList.Add(new Thread(new ThreadStart(StartBuyStuff)));
            Console.WriteLine("Added Thread" + i +  ": " +ThreadList[i].ManagedThreadId);
        }

        return;
    }

    public void StartThreads(){
        foreach(Thread t in ThreadList){
            Console.WriteLine(t.ManagedThreadId + " getting 50 dollars from the bank");
            t.Start();
            Console.WriteLine(t.ManagedThreadId + " am done getting 50 dollars from the bank");

        }
    }
    public void StartBuyStuff(){
        BuyStuff(50);
    }
    private int BuyStuff(int cost){
        Console.WriteLine("Taking " + cost + " out to get some of my stuff done ");
        return cost;
    }
    

}