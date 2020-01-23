using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_item = 0;
            int[] arr;
            Console.WriteLine("Enter how many elements should be in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n]; //array
            Random random = new Random();

            Console.WriteLine("Array elements:");
            for (int i = 0; i<arr.Length; i++) //filling an array with random numbers
            {
                arr[i] = random.Next(-100, 100);
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++) //Finding the maximum element in an array
            {
                if (max_item < arr[i])
                {
                    max_item = arr[i];
                }
            } 
            Console.WriteLine($"The maximum element in an array: {max_item}");
            Console.ReadKey(); // Delay
        }
    }
}
