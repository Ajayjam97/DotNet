using System;
using Library;
using ConsoleApp.Fundamental;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Answer().GetAnswer(40,2)}");

            MyDateTime.work();
            
        }
    }
}
