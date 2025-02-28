namespace Phase1Part2;

using System;
using System.ComponentModel;
using System.Threading;

class BankAccount{
    private static float balance = 100;
    //This is how you create a lock 
    private static readonly object balancelock = new object();
    private static BankAccount? instance;
    
    public BankAccount(){
        Console.WriteLine("Your bank account has 100 bucks in it");
    }

    public void AddToBalance(float addAmount){
        //Locks it so only one user can add to balance
        lock(balancelock){
            addAmount = (float)Math.Round(addAmount, 2);
            balance+=addAmount;
            Console.WriteLine($"Added ${addAmount}. New balance: ${balance}");
        }
    }
    
    public static BankAccount GetInstance(){
        if(instance == null){
            instance = new BankAccount();
        }
        return instance;
    }

    public void RemoveToBalance(float lossAmount){
        //Locks it so only one user widthraw to balance
        lock(balancelock){
            lossAmount = (float)Math.Round(lossAmount, 2);
            balance-=lossAmount;
            Console.WriteLine($"Withdrawed ${lossAmount}. New balance: ${balance}");
        }
    }

}