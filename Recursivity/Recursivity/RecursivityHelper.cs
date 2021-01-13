using System;
using System.Collections.Generic;
using System.Text;

namespace Recursivity
{
    public static class RecursivityHelper
    {
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
