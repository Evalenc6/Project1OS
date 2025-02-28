namespace Phase1Part2;

using System;

class BankAccount(){
    priavte static float balance = 100;
    
    public BankAccount(){
        Console.WriteLine("Your bank account has 100 bucks in it");
    }

    public static AddToBalance(float addAmount){
        addAmount = (float)Math.Round(addAmount, 2);
        BankAccount.balance+=addAmount;
    }


    public static removeToBalance(float lossAmount){
        lossAmount = (float)Math.Round(lossAmount, 2);
        BankAccount.balance-=lossAmount;
    }

}