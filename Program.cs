using System;

namespace DelegatesDemo
{
    class Program2
    {
        static int[] Filter(int[] numbers, Func<int, bool> condition)
        {
            int[] result = new int[numbers.Length];
            int index = 0;
            foreach (int n in numbers)
            {
                if (condition(n))
                {
                    result[index] = n;
                    index++;
                }
            }

            int[] finalResult = new int[index];
            for (int i = 0; i < index; i++)
            {
                finalResult[i] = result[i];
            }
            return finalResult;
        }

        static void Print(string title, int[] arr)
        {
            Console.Write(title + ": ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] nums = { 1, 2, 3, 12, 15, 7, 20 };

            int[] even = Filter(nums, n => n % 2 == 0);
            int[] greater10 = Filter(nums, n => n > 10);
            int[] divisible3 = Filter(nums, n => n % 3 == 0);

            Print("Even", even);
            Print(">10", greater10);
            Print("Divisible by 3", divisible3);
        }
    }
}