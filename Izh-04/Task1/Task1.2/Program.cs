using System;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            //int[] arr = {3, 4, 8, 3, 3, 5, 6, 6, 1 }; // for test
            int left_sum = 0, right_sum = 0, result = 0;
            Console.WriteLine("Enter how many elements should be in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n]; //array
            Random random = new Random();

            Console.WriteLine("Array elements:");
            for (int i = 0; i < arr.Length; i++) //filling an array with random numbers
            {
                arr[i] = random.Next(-100, 100);
                Console.Write($"{arr[i]}, ");
            }

            for (int i = 1; i < arr.Length; i++)
            {
                right_sum += arr[i];
            }

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if(left_sum == right_sum)
                {
                    result = i;                    
                    break;
                }                
                else
                {
                    result = -1;
                }
                left_sum += arr[i];
                right_sum -= arr[i + 1];
            }
            
            Console.WriteLine($"Result: {result}");
            Console.ReadKey(); // Delay
        }
    }
}
