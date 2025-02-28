namespace Phase1Part2;

using System;
using System.Threading;

class BankAccount{
    private static float balance = 100;
    //This is how you create a lock 
    private static readonly object balancelock = new object();

    
    public BankAccount(){
        Console.WriteLine("Your bank account has 100 bucks in it");
    }

    public static void AddToBalance(float addAmount){
        //Locks it so only one user can add to balance
        lock(balancelock){
            addAmount = (float)Math.Round(addAmount, 2);
            balance+=addAmount;
            Console.WriteLine($"Added ${addAmount}. New balance: ${balance}");
        }
    }


    public static void RemoveToBalance(float lossAmount){
        //Locks it so only one user widthraw to balance
        lock(balancelock){
            lossAmount = (float)Math.Round(lossAmount, 2);
            balance-=lossAmount;
            Console.WriteLine($"Added ${lossAmount}. New balance: ${balance}");
        }
    }

}