namespace Phase1Part3;

using System;

class TrafficDeadlock{

    public bool roadlock1;

    public bool roadlock2;

    public TrafficDeadlock(){
        roadlock1 = false;
        roadlock2 = false;
    }


    public void goToRoad2(){
        while(roadlock2 == true){
            Console.WriteLine("Road 2 blocked can't move");
            Thread.Sleep(100);
        }
        roadlock2 = true;
    }
    
    public void goToRoad1(){
        while(roadlock1 == true){
            Console.WriteLine("Road 1 blocked can't move");
            Thread.Sleep(100);
        }
        roadlock1 = true;
    }
    
}

