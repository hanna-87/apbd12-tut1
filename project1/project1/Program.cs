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

        double sum = 0;

        // Loop through the array to calculate the sum of the numbers
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Calculate and return the average
        return sum / numbers.Length;
    }
    
