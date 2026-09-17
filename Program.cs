using System;

class Program
{
    static void Main(string[] args)
    {

        //Section:Question1
        int[] arrayofsum1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };  // valid input: sample array
        int[] arrayofsum2 = { 1, 1, -5, 4, -6, 2, 1, -2, 4 };   // valid input: sample array
        int[] arrayofsum3 = { -5, -2, -8, -1 };                 // valid input: array with negative numbers only
        int[] arrayofsum4 = { };                                // valid input: empty array

        Console.WriteLine($"Result 1: {Question1.MaxSequence(arrayofsum1)}"); // Expected: 6
        Console.WriteLine($"Result 2: {Question1.MaxSequence(arrayofsum2)}"); // Expected: 5
        Console.WriteLine($"Result 3: {Question1.MaxSequence(arrayofsum3)}"); // Expected: 0
        Console.WriteLine($"Result 4: {Question1.MaxSequence(arrayofsum4)}"); // Expected: 0

        //Section: Question2
        Console.WriteLine($"Result Sum of Numbers: {Question2.SumOfWords("Input.txt")}"); // Expected: 183

    }
}