// FixedArrayAverage -- Average a fixed array of numbers using a loop.
namespace FixedArrayAverage
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };
            // Accumulate the values in the array into the variable sum.
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + doublesArray[i];
            }
            // Now calculate the average.
            double average = sum / 10;
            Console.WriteLine(average);
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
