using System;

namespace FridayNightRandomReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple Juice", "coke", "fanta", "sprite", "milk" };
            string[] movie = { "Titanic", "Rambo", "Speed", "King Kong", "Fury" };
            randomFood = PickRandomElemtFromArray(foods);
            randomDrink = PickRandomElemtFromArray(drinks);
            randomMovie = PickRandomElemtFromArray(movie);
            Console.WriteLine($"Tonight you will have some {randomFood} whit {randomDrink} and {randomMovie}");
        }
        private static int GenerateRandomIndex (string[] someArray)
        {
            Random rnd = new Random();
        int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string PickRandomElemtFromArray(string[] someArray)
        { string randomElement = someArray[GenerateRandomIndex(someArray)];
           return randomElement; 
        }
    }    
} 

