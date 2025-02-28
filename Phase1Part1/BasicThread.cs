namespace Phase1Part1;

using System;
using System.Threading;
using System.Collections.Generic;

class BasicThread{
    
    protected List<Thread> ThreadList = new List<Thread>();
    private Random rnd = new Random();
 
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
        }
        //This is used to make sure that the threads are all completed before program finishes
        foreach(Thread t in ThreadList){
            t.Join();
        }
        Console.WriteLine("Finished All Threads");
    }
    public void StartBuyStuff(){
        BuyStuff(50);
    }
    private int BuyStuff(int cost){
        //Added a delay so that we can make sure that all of them are concurrent
        int delay = rnd.Next(1000, 5000);
        //We can use Thread.CurrentThread to see which thread is currently working
        Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is taking $" + cost+" to buy stuff. (Delay: "+ delay+" ms)");
        
        Thread.Sleep(delay);

        Console.WriteLine("Thead " + Thread.CurrentThread.ManagedThreadId + " got " + cost+" from the bank.");
        return cost;
    }
    

}