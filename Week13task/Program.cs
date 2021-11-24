using System;
using System.IO;

namespace Week13task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your directory name:");
            string newDirectory = Console.ReadLine();

            CreateMyDirectory(newDirectory);
        }

        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\";
            string directoryFullPath = $@"{rootDirectory}\{myDirectoryName}";
            if (Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {rootDirectory}.");
            }
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directoy {myDirectoryName} has been created.");
            }
        }
    }
}
