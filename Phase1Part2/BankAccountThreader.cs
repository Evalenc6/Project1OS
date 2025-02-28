namespace Phase1Part2;

using System;
using System.Threading;
using System.Collections.Generic;

class BankAccountThreader{

    private List<BankUser> ListOfUsers;
    private Random rnd = new Random();
    public BankAccountThreader(){
        ListOfUsers = new List<BankUser>();
    }

    public void populateList(int amount){
        for(int i = 0; i < amount; i++){
            ListOfUsers.Add(new BankUser());
        }
    } 
    public void testLock(){
        //Create our concurrency
        List<Thread> ThreadList = new List<Thread>();
        foreach(BankUser BU in ListOfUsers){
            int DepOrWithd = rnd.Next(0,2);
            float amount = (float)rnd.NextDouble()*100;
            //This pointer/lambda function allows for calling methods with 
            Thread t = new Thread(() => {
                if(DepOrWithd == 0){
                    BU.Deposit(amount);
                }else{
                    BU.Withdraw(amount);
                }
            });

            ThreadList.Add(t);
            t.Start();
        }

        foreach(Thread t in ThreadList){
            t.Join();
        }

        Console.WriteLine("Transactions Completed");


    }

}