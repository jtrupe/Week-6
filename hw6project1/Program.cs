/// Homework 6 Project 1
///
/// @author: Julian Trupe
/// Date:  September 27, 2021
///
/// Problem Statement: Write a program that will create a copy of an array
//
/// Overall Plan:
/// 1) Greet the user and explain program
/// 2) Prompt user to enter a number which will be the size of the array
/// 3) Initialize array at specified size
/// 4) Looping through the array, assign each element of the array a random number less than 100
/// 5) Create a new array of the same size as the first array
/// 6) Loop through the new array and assign each element the value in the same position in the first array
/// 7) Check that the two arrays are the same
/// 

using System;

namespace hw6project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will make a copy of a random array:");
            Console.WriteLine("What is the length of the array you want to make a copy of?");

            int arrayLength = int.Parse(Console.ReadLine());
            int[] randArray = randomIntArrayMaker(arrayLength);
            //int[] newArray = easyIntArrayCopier(randArray); //
            int[] newArray = intArrayCopier(randArray);
            bool arraysMatch = intArrayChecker(randArray, newArray);

        }

        //method takes in an int and returns an returns an array of size specified, and with random values
        private static int[] randomIntArrayMaker(int length)
        {
            int[] randomIntArray = new int[length];
            for (int i = 0; i < randomIntArray.Length; i++)
            {
                Random rand = new Random();
                randomIntArray[i] = rand.Next(100);
                Console.WriteLine("Number " + ((int)i + 1) + ": " + randomIntArray[i]);
            }
            Console.WriteLine("Random Length: " + randomIntArray.Length);
            return randomIntArray;
        }

        // clones an array without needing to loop through it
        private static int[] easyIntArrayCopier(int[] inputArr)
        {
            return inputArr;
        }

        // loops through an array and returns a copy
        private static int[] intArrayCopier (int[] inputArr)
        {
            Console.WriteLine("Your new array is: ");
            int[] copiedArray = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                copiedArray[i] = inputArr[i];
                Console.WriteLine("Number " + ((int)i + 1) + ": " + copiedArray[i]);
            }
            return copiedArray;
        }

        // checks two arrays are the same, returns false otherwise
        private static bool intArrayChecker(int[] array1, int[] array2)
        {
            if(array1.Length != array2.Length)
            {
                Console.WriteLine("Your arrays aren't even the same size!");
                return false;
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if(array1[i] != array2[i])
                    {
                        Console.WriteLine("The numbers at index " + i + "did not match");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine("Array copied successfully!");
                return true;
            }
        }
    }
}
