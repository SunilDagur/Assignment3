using System;

public static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Input array cannot be null or empty.");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Length;
        return average;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = MathHelper.CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
    }
}
