using System;

namespace GettingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            //this is a new version of the code that I wrote//
            string input = Console.Readline();
            Console.Writeline($"You are {input} years old!")
        }
    }
} 


