using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        #region Arrays
        Console.WriteLine("************Start Arrays**************");

        // Set Up
        var numbers = new int[50];
        var rand = new Random();

        // Populate the array with 50 random numbers between 0 and 50
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 51);
        }

        // Print the capacity of the array to the console
        Console.WriteLine($"Array Capacity: {numbers.Length}");

        Console.WriteLine("-------------------");

        // Print the numbers to the console
        Console.WriteLine("All Numbers:");
        NumberPrinter(numbers);
        Console.WriteLine("-------------------");

        // Reverse the contents of the array and then print the array out to the console
        Console.WriteLine("All Numbers Reversed:");
        ReverseArray(numbers);
        NumberPrinter(numbers);
        Console.WriteLine("-------------------");

        // Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
        Console.WriteLine("Multiple of three = 0: ");
        ThreeKiller(numbers);
        NumberPrinter(numbers);
        Console.WriteLine("-------------------");

        // Sort the array in order now
        Array.Sort(numbers);
        Console.WriteLine("Sorted numbers:");
        NumberPrinter(numbers);

        Console.WriteLine("\n************End Arrays*************** \n");
        #endregion

        #region Lists
        Console.WriteLine("************Start Lists**************");

        // Set Up
        var numberList = new List<int>();

        // Populate the List with 50 random numbers between 0 and 50
        for (int i = 0; i < 50; i++)
        {
            numberList.Add(rand.Next(0, 51));
        }

        // Print the new capacity
        Console.WriteLine($"List Capacity: {numberList.Capacity}");

        Console.WriteLine("---------------------");

        // Create a method that prints if a user number is present in the list
        Console.WriteLine("What number will you search for in the number list?");
        if (int.TryParse(Console.ReadLine(), out int userNumber))
        {
            if (numberList.Contains(userNumber))
                Console.WriteLine($"The number {userNumber} is present in the list.");
            else
                Console.WriteLine($"The number {userNumber} is not present in the list.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("-------------------");

        Console.WriteLine("All Numbers:");
        // Uncomment this method to print out your numbers from arrays or lists
        // NumberPrinter();
        Console.WriteLine("-------------------");

        // Create a method that will remove all odd numbers from the list then print results
        Console.WriteLine("Evens Only!!");
        numberList.RemoveAll(n => n % 2 != 0);
        NumberPrinter(numberList);
        Console.WriteLine("------------------");

        // Sort the list then print results
        Console.WriteLine("Sorted Evens!!");
        numberList.Sort();
        NumberPrinter(numberList);
        Console.WriteLine("------------------");

        // Convert the list to an array and store that into a variable
        var newArray = numberList.ToArray();

        // Clear the list
        numberList.Clear();

        Console.WriteLine("\n************End Lists*************** \n");
        #endregion
    }

    private static void PopulateArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(51);
            }
        }
        private static void NumberPrinter(IEnumerable<int> numbers)
        {
            {
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
        }

        private static void ThreeKiller(int[] numbers)
        {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 3 == 0)
                    {
                        numbers[i] = 0;
                    }
                }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(num => num % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
            {
                if (numberList.Contains(searchNumber))
                {
                    Console.WriteLine($"The number {searchNumber} exists in the list.");
                }
                else
                {
                    Console.WriteLine($"The number {searchNumber} does not exist in the list.");
                }
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++) 
            {
                numbers[i] = rng.Next(0 , 51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            var reversed = new int[array.Length];
            for(int i = array.Length - 1; i >= 0; i--) 
            {
                for(int x = 0; x < reversed.Length; x++) 
                {
                    reversed[x] = array[i];
                }
                
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
