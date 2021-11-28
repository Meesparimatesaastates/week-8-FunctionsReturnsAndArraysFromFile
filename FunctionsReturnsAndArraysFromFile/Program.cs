using System;

namespace FunctionsReturnsAndArraysFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplyRandomDrinks();
            DisplyRandomMovie();

        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);
            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked {randomFood}");
        }
        private static void DisplyRandomDrinks()
        {
            string[] drinks = { "apple Juice", "coke", "fanta", "sprite", "milk" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);
            string randomDrinks = drinks[randomIndex];
            Console.WriteLine($"Computer picked {randomDrinks}");

        }
        private static void DisplyRandomMovie()
        {
            string[] movie = { "Titanic", "Rambo", "Speed", "King Kong", "Fury" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movie.Length);
            string randomMovie = movie[randomIndex];
            Console.WriteLine($"Computer picked {randomMovie}");

        }
    }
}
