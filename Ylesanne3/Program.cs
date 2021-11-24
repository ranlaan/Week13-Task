using System;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string starsFile = @"C:\Users\opilane\Samples\LogITpe21\stars.txt";
            string planetsFile = @"C:\Users\opilane\Samples\LogITpe21\planets.txt";
            string MilkyWayFile = @"C:\Users\opilane\Samples\LogITpe21\MilkyWay.txt";

            string[] MilkyWayData = File.ReadAllLines(MilkyWayFile);
            string[] starsData = File.ReadAllLines(MilkyWayFile);
            string[] planetData = File.ReadAllLines(MilkyWayFile);
        }
    }
}
