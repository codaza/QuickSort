using System;

namespace QuickSortAlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

            Console.ReadLine();
        }

        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivotIndendedPosition = minIndex;  
            int pivotValue = array[maxIndex]; 

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < pivotValue) 
                {
                    pivotIndendedPosition++;
                    if (pivotIndendedPosition<=i) 
                        Swap(ref array[pivotIndendedPosition-1], ref array[i]);
                }
            }

            
            if (pivotIndendedPosition!=maxIndex)
                Swap(ref array[pivotIndendedPosition], ref array[maxIndex]);
            return pivotIndendedPosition;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
    }
}
