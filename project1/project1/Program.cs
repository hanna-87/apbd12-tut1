// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");
Console.WriteLine("You can do it!")
public class Calculator
{
    // Static method to calculate the average of an array of integers
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        double sem = 0;

        // Loop through the array to calculate the sum of the numbers
        foreach (int number in numbers)
        {
            sem += number;
        }

        // Calculate and return the average
        return sem / numbers.Length;
    }
    
    class Calculator
    {
        // Static method to return the maximum value in an array of integers
        public static int FindMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            int max = numbers[0]; // Assume the first element is the largest initially

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number; // Update the max value when a larger number is found
                }
            }

            return max;
        }
    }
