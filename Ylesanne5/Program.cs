using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string filepath = @"C:\Users\opilane\Samples\LogITpe21\FunFacts.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            Console.WriteLine(dataFromFile[0]);
            Random rnd = new Random();
            Console.WriteLine(dataFromFile);
        }
        private static void ReadDataFromArray(string[] someArray)
        {
            foreach (string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
        private static void DisplayQuotes(string[] someArray, int someNumber)
        {
            Console.WriteLine(someArray);
        }
    }
}
