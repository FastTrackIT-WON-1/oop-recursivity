using System;
using System.Text;
using System.Threading;

namespace Recursivity
{
    class Program
    {
        static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        static void FindIndexOf10()
        {
            int element = 10;
            int index = RecursivityHelper.IndexOfElement(element, array);

            StringBuilder output = new StringBuilder();
            output.AppendLine($"{DateTime.Now:HH:mm:ss:ffff}) Index of {element} = {index}");
            output.AppendLine($"Index of {element} = {index}");

            Console.WriteLine(output.ToString());
        }

        static void FindIndexOf2()
        {
            int element = 2;
            int index = RecursivityHelper.IndexOfElement(element, array);

            StringBuilder output = new StringBuilder();
            output.AppendLine($"{DateTime.Now:HH:mm:ss:ffff}) Index of {element} = {index}");
            output.AppendLine($"Index of {element} = {index}");

            Console.WriteLine(output.ToString());
        }

        static void Main(string[] args)
        {
            int fibo = RecursivityHelper.Fibonacci(5);
            Console.WriteLine(fibo);

            Console.WriteLine("--------------------");

            fibo = RecursivityHelper.FibonacciWithCache(5);
            Console.WriteLine(fibo);

            Console.WriteLine("--------------------");

            fibo = RecursivityHelper.FibonacciWithCache(6);
            Console.WriteLine(fibo);

            /*
             * Beware of multithreading race condition when writing static members!
            Thread t1 = new Thread(FindIndexOf10);
            Thread t2 = new Thread(FindIndexOf2);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            int element = 10;
            int index = RecursivityHelper.IndexOfElement(element, array);

            Console.WriteLine($"Index of {element} = {index}");
            Console.WriteLine($"Count of recursive calls: {RecursivityHelper.RecursiveIndexOfCounter}");

            element = 2;
            index = RecursivityHelper.IndexOfElement(element, array);

            Console.WriteLine($"Index of {element} = {index}");
            Console.WriteLine($"Count of recursive calls: {RecursivityHelper.RecursiveIndexOfCounter}");

            */
        }
    }
}
