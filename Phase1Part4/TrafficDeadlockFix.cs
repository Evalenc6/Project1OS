namespace Phase1Part3;

using System;

class TrafficDeadlockFix{

    private static readonly object roadlock1 = new object();
    private static readonly object roadlock2 = new object();
    Random rnd = new Random();


    public void CarA(){
        bool moving = true;
        while(moving){
            if(Monitor.TryEnter(roadlock1,500)){
                try{
                    Console.WriteLine("Car A has entered Road 1 and is now moving towards road 2");
                    Thread.Sleep(100);
                    if(Monitor.TryEnter(roadlock2,500)){
                        try{
                            Console.Write("Car A has locked Road 2 and passed.");
                            moving = false;
                        }finally{
                            Monitor.Exit(roadlock2);
                        }
                    }else{
                        Console.WriteLine("Car A couldn't get into road 2. Releasing road 1 and running later");
                    }
                }finally{
                    Monitor.Exit(roadlock1);
                }
                Thread.Sleep(100);
            }
        }
        
    }

    public void CarB(){
bool moving = true;
        while(moving){
            if(Monitor.TryEnter(roadlock2,500)){
                try{
                    Console.WriteLine("Car B has entered Road 2 and is now moving towards road 1");
                    Thread.Sleep(100);
                    if(Monitor.TryEnter(roadlock1,500)){
                        try{
                            Console.Write("Car B has locked Road 2 and passed.");
                            moving = false;
                        }finally{
                            Monitor.Exit(roadlock1);
                        }
                    }else{
                        Console.WriteLine("Car A couldn't get into road 1. Releasing road 2 and running later");
                    }
                }finally{
                    Monitor.Exit(roadlock2);
                }
                Thread.Sleep(100);
            }
        }
    }
    
    
}

