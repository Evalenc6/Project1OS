namespace Phase1Part2;

using System;

class BankUser{
    private static int userIDCounter = 1;
    private int id;
    private BankAccount account;
    public BankUser(){
        id = userIDCounter++;
        account = new BankAccount();
    }
    public void Deposit(float amount){
        Console.WriteLine($"User ${id} depositing ${amount}...");
        BankAccount.AddToBalance(amount);
    }

    public void Withdraw(float amount){
        Console.WriteLine($"User ${id} withdrawing ${amount}...");
        BankAccount.RemoveToBalance(amount);
    }

}