using System;

namespace Recursivity
{
    class Program
    {
        static void Main(string[] args)
        {
            int element = 1;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int index = RecursivityHelper.IndexOfElement(element, array);

            Console.WriteLine($"Index of {element} = {index}");
        }
    }
}
