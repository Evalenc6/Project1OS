// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(){
        BasicThread BT = new BasicThread();
        BT.CreateThreads(25);
        BT.StartThreads();
    }
}
