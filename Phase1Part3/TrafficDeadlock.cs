namespace Phase1Part3;

using System;

class TrafficDeadlock{

    private static readonly object roadlock1 = new object();
    private static readonly object roadlock2 = new object();


    public void CarA(){
        lock(roadlock1){
            Console.WriteLine("Car A has entered road 1 and moving towards road 2");
            Thread.Sleep(100);

            lock(roadlock2){
                Console.WriteLine("Car A has locked Road 2 and passed");
            }
        }
    }

    public void CarB(){
        lock(roadlock2){
            Console.WriteLine("Car B has entered road 2 and moving towards road 1");
            Thread.Sleep(100);
            lock(roadlock1){
                Console.WriteLine("Car B has locked Road 1 and passed");
            }

        }
    }
    
    
}

