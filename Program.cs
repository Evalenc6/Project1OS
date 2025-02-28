using Phase1Part1;
using Phase1Part2;
class Program{
    static void Main(){
        //For Phase 1 Part 1
        //Phase1Part1();

        //For Phase 2 Part 2
        Phase1Part2();
        
    }
    static void Phase1Part1(){
        BasicThread BT = new BasicThread();
        BT.CreateThreads(25);
        BT.StartThreads();
    }

    static void Phase1Part2(){
        BankAccountThreader bankSim = new BankAccountThreader();
        bankSim.populateList(11);
        bankSim.testLock();
    }
}
