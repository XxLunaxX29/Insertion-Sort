using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    internal class Order
    {
        public static long SwapCount = 0;
        public static long ComparisonCount = 0;

        public static void InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int actual = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    ComparisonCount++;
                    if (array[j] > actual)
                    {
                        array[j + 1] = array[j];
                        SwapCount++;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = actual;
            }
        }
    }
}
