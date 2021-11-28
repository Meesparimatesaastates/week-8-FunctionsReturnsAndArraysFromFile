using System;

namespace FridayNightRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplyRandomDrinks();
            DisplyRandomMovie();


        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Console.WriteLine($"Computer picked {foods[GenerateRandomIndex(foods)]}");
        }


        private static void DisplyRandomDrinks() 
        {
        string[] drinks = { "apple Juice", "coke", "fanta", "sprite", "milk" };
        Console.WriteLine($"Computer picked {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplyRandomMovie()
        {
            string[] movie = { "Titanic", "Rambo", "Speed", "King Kong", "Fury" };

            Console.WriteLine($"Computer picked {movie[GenerateRandomIndex(movie)]}");
        }
        

    }

    }
   
    
    
    
 

