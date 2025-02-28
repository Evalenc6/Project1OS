namespace Phase1Part2;

using System;
using System.Threading;
using System.Collections.Generic;

class BankAccountThreader{

    private List<BankUser> ListOfUsers;
    public BankAccountThreader(){
        ListOfUsers = new List<BankUser>();
    }

    public void populateList(int amount){
        for(int i = 0; i < amount; i++){
            ListOfUsers.Add(new BankUser());
        }
    } 
    public void testLock(){
        foreach(BankUser BU in ListOfUsers){
            
        }
    }

}