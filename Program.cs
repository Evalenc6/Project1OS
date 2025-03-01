
using Phase1Part1;
using Phase1Part2;
using Phase1Part3;
using Phase2Part1;
class Program{
    static void Main(){
        //For Phase 1 Part 1
        //Phase1Part1();

        //For Phase 1 Part 2
        //Phase1Part2();

        //For Phase 1 Part 3 Deadlock
        //Phase1Part3();
        
        //For Phase 1 Part 4 Deadlock
        //Phase1Part4();

        //For Phase 2 Part 1
        Phase2Part1();

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

    static void Phase1Part3(){
        TrafficDeadlock traffic = new TrafficDeadlock();

        Thread carAThread = new Thread(traffic.CarA);
        Thread carBThread = new Thread(traffic.CarB);

        carAThread.Start();
        carBThread.Start();

        carAThread.Join();
        carBThread.Join();

        Console.WriteLine("Traffic has completed");
    }

    static void Phase1Part4(){
        TrafficDeadlockFix traffic = new TrafficDeadlockFix();
        Thread carAThread = new Thread(traffic.CarA);
        Thread carBThread = new Thread(traffic.CarB);

        carAThread.Start();
        carBThread.Start();

        carAThread.Join();
        carBThread.Join();

        Console.WriteLine("Traffic sim complete");

    }

    static void Phase2Part1(){
        Console.Write("Run as (1) Server or (2) Client? ");
        string choice = Console.ReadLine();

        if(choice =="1"){
            PipeServer.Main();
        }else if(choice =="2"){
            PipeClient.Main();
        }
    }

    static void Phase2Part2(){
        return;
    }

    static void Phase2Part3(){
        return;
    }

    static void Phase2Part4(){
        return;
    }
}
