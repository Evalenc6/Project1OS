using Phase1Part1;
class Program{
    static void Main(){
        //For Phase 1 Part 1
        Phase1Part1();
        
    }
    static void Phase1Part1(){
        BasicThread BT = new BasicThread();
        BT.CreateThreads(25);
        BT.StartThreads();
    }
}
