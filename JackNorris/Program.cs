using System;
using System.IO;

namespace JackNorris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomJackNorrisJoke;
            randomJackNorrisJoke = GetRandomFromFile("chuck.txt");
            
            Console.WriteLine($"There is joke for you: {randomJackNorrisJoke}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\source\repos\Week 8\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
            return randomElement;
        }
    }
}
