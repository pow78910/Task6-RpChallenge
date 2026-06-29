using System;
using System.Runtime.InteropServices;

namespace RpChallenge
{
    class Program()
    {
        static void Main(string[] args)
        {
            Start(); 
        }


        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to this roleplay game, please choose from one of the options below");
             Console.WriteLine("1.Requirements for this challenge"); 
             Console.WriteLine("2.Run Game");

           

           


        while(true)
        {
             ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.KeyChar)
            {
                case '1':Files.OutputFile("./TextFiles/Requirements.txt"); Console.ReadKey(); Console.Clear(); break;
                case '2': GameRunning.GameRun(); Console.ReadKey(); break;
                default: Console.WriteLine("Invalid Input, try again"); break;
            }
        }
        
    }
    }
}