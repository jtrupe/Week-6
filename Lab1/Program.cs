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

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNum = rand.Next(100);
            Console.WriteLine("I've chosen a random number between 1 and 100");
            Console.WriteLine("Can you guess it?");
            int userGuess = int.Parse(Console.ReadLine());
            while(userGuess != secretNum)
            {
                if (userGuess > secretNum)
                {
                    Console.WriteLine("Wrong! My number is less than that");
                    userGuess = int.Parse(Console.ReadLine());
                }
                if(userGuess < secretNum)
                {
                    Console.WriteLine("Wrong! My number is more than that");
                    userGuess = int.Parse(Console.ReadLine());
                }
            }
            if(userGuess == secretNum)
            {
                Console.WriteLine("You got it! Great job!");
            }
        }
    }
}
