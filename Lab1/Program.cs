/// Week 6 Lab 1
///
/// @author: Julian Trupe
/// Date:  September 30, 2021
///
/// Problem Statement: Create a random number guessing game
//
/// Overall Plan:
/// 1) Pick a random number
/// 2) Greet user and prompt to guess the secret number
/// 3) Tell the user if the secret number is higher or lower (or correct)
/// 4) Let the user guess again until they get it correct
/// 5) Tell the user when they guess correct and how many guesses it took

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numGuesses = 0;
            int secretNum = rand.Next(100);
            Console.WriteLine("I've chosen a random number between 1 and 100");
            Console.WriteLine("Can you guess it?");
            int userGuess = int.Parse(Console.ReadLine());
            numGuesses++;
            while (userGuess != secretNum)
            {
                if (userGuess > secretNum)
                {
                    Console.WriteLine("Wrong! My number is less than that");
                    numGuesses++;
                    userGuess = int.Parse(Console.ReadLine());
                }
                if(userGuess < secretNum)
                {
                    Console.WriteLine("Wrong! My number is more than that");
                    numGuesses++;
                    userGuess = int.Parse(Console.ReadLine());
                }
            }
            if(userGuess == secretNum)
            {
                Console.WriteLine("You got it! It only took you " + numGuesses + " guesses");
            }
        }
    }
}
