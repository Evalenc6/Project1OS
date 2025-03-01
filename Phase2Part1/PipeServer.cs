namespace Phase2Part1;
using System;
using System.IO;
using System.IO.Pipes;
using System.Xml;

class PipeServer{
    public static void Main(){
        Console.WriteLine("Starting Pipe Server...");
        using(NamedPipeServerStream pipeServer = new NamedPipeServerStream("TestPipe", PipeDirection.InOut)){
            Console.WriteLine("Waiting for client connection");
            pipeServer.WaitForConnection();
            Console.WriteLine("Client Connected!");

            using(StreamReader reader = new StreamReader(pipeServer))
            using(StreamWriter writer = new StreamWriter(pipeServer)){
                writer.AutoFlush = true;
                string message;
                while((message = reader.ReadLine())!= null){
                    Console.WriteLine($"Recieved: {message}");
                    writer.WriteLine($"Server recieved: {message}");
                }

            }
        }
        Console.WriteLine("Pipe Server shutting down.");
    
        }
    }