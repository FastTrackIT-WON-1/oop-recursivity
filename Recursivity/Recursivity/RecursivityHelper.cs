using System;
using System.Collections.Generic;
using System.Text;

namespace Recursivity
{
    public static class RecursivityHelper
    {
        private const int MaxFibonacciCacheSize = 100;
        private static int[] FibonacciCache = new int[MaxFibonacciCacheSize];

        public static int FibonacciWithCache(int n)
        {
            if (n >= 100)
            {
                throw new ArgumentOutOfRangeException(nameof(n), $"Param '{nameof(n)}' must be less than {MaxFibonacciCacheSize}");
            }

            if (n <= 1)
            {
                return n;
            }
             
            if (FibonacciCache[n] > 0)
            {
                return FibonacciCache[n];
            }
            else
            {
                Console.WriteLine($"Called FibonacciWithCache({n})");

                int fibo = FibonacciWithCache(n - 1) + FibonacciWithCache(n - 2);
                FibonacciCache[n] = fibo;
                return fibo;
            }
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            Console.WriteLine($"Called Fibonacci({n})");

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int IndexOfElement(int element, int[] array)
        {
            return IndexOfElement(element, array, 0, array.Length - 1);
        }

        public static int IndexOfElement(int element, int[] array, int startIndex, int endIndex)
        {
            if (array != null && 
                startIndex >= 0 && 
                endIndex < array.Length && 
                startIndex <= endIndex)
            {
                // This does not overflow:
                // int middle = startIndex + (endIndex - startIndex) / 2;
                int middleIndex = (startIndex + endIndex) / 2;
                if (array[middleIndex] == element)
                {
                    return middleIndex;
                }
                else if (element < array[middleIndex])
                {
                    return IndexOfElement(element, array, startIndex, middleIndex - 1);
                }
                else
                {
                    return IndexOfElement(element, array, middleIndex + 1, endIndex);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
