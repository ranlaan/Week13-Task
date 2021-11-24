using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\LogITpe21\";
            Console.WriteLine("Enter .txt file name:");
            string fileName = Console.ReadLine();
            string fullFilepath = $@"{rootDirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilepath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{fileName} directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullFilepath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
            else
            {
                File.Create(fullFilepath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
        }
    }
}
