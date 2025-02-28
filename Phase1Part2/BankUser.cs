namespace Phase1Part2;

using System;

class BankUser{
    private static int userIDCounter = 1;
    private int id;
    private BankAccount account;
    public BankUser(){
        id = userIDCounter++;
        account = BankAccount.GetInstance();
    }
    public void Deposit(float amount){
        Console.WriteLine($"User {id} depositing ${amount}...");
        account.AddToBalance(amount);
    }

    public void Withdraw(float amount){
        Console.WriteLine($"User {id} withdrawing ${amount}...");
        account.RemoveToBalance(amount);
    }

}