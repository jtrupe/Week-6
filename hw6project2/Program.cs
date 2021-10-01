/// Homework 6 Project 2
///
/// @author: Julian Trupe
/// Date:  September 27, 2021
///
/// Problem Statement: Write a program that will reverse the order of an array
//
/// Overall Plan:
/// 1) Greet the user and prompt them to enter a number which will be the array length N
/// 2) Generate a random integer array of length N
/// 3) Print the original array to the console
/// 4) Reverse teh order of the array
/// 5) Print the reversed array to the console
/// 

using System;

namespace hw6project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will reverse the order of a random array:");
            Console.WriteLine("What is the length of the array you want to reverse");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbersArr = randomIntArrayMaker(arrayLength);
            Console.WriteLine("Original Array: ");
            printArray(numbersArr);
            int[] reversedArray = arrayReverser(numbersArr);
            Console.WriteLine("Reversed Array: ");
            printArray(reversedArray);
        }

        // method from project1 -- creates random int array of size "length"
        private static int[] randomIntArrayMaker(int length)
        {
            int[] randomIntArray = new int[length];
            for (int i = 0; i < randomIntArray.Length; i++)
            {
                Random rand = new Random();
                randomIntArray[i] = rand.Next(100);
            }
            return randomIntArray;
        }
        // method takes in an array and returns the array with its elements reversed.
        private static int[] arrayReverser(int[] inputArr)
        {
            float arrayMidoint = inputArr.Length / 2;
            for(int i=0; i<arrayMidoint; i++)
            {
                int temp = inputArr[i];
                inputArr[i] = inputArr[inputArr.Length -1- i];
                inputArr[inputArr.Length -1- i] = temp;
            }
            return inputArr;
        }
        //method prints array
        private static void printArray(int[] inputArr)
        {
            for(int i =0; i<inputArr.Length; i++)
            {
                Console.WriteLine("Index " + ((int)i) + ": " + inputArr[i]);
            }
        }
    }
}
