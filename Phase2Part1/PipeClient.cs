namespace Phase2Part1;
using System;
using System.IO;
using System.IO.Pipes;
using System.Xml;

class PipeClient{
    public static void Main(){
        Console.WriteLine("Connecting to Pipe Server...");
        using(NamedPipeClientStream pipeClient = new NamedPipeClientStream(".","TestPipe", PipeDirection.InOut)){
            pipeClient.Connect();
            Console.WriteLine("Connected to the server");

            using(StreamReader reader = new StreamReader(pipeClient))
            using(StreamWriter writer = new StreamWriter(pipeClient)){
                writer.AutoFlush = true;
                string[] messages = {"Hello, Server", "How are you?", "Goodbye"};
                foreach (string msg in messages){
                    Console.WriteLine($"Sending Message {msg}");
                    writer.WriteLine(msg);

                    string response = reader.ReadLine();
                    Console.WriteLine($"Server Response: {response}");
                }

            }
        }
        Console.WriteLine("Shutting down.");
    
        }
    }
