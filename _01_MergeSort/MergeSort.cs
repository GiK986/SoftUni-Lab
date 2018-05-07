using System;

namespace _01_MergeSort
{
    public class MergeSort
    {
        public static void Main(string[] args)
        {
            
        }
    }


    public class Mergesort<T> where T : IComparable
    {
        private static T[] aux;
        
        public static void Sort(T[] arr)
        {
            
        }

        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            if (IsLess(arr[mid], arr[mid + 1]))
            {
                return;
            }

            for (int index = lo; index < hi + 1; index++)
            {
                aux[index] = arr[index];
            }
        }

        private static bool IsLess(IComparable left, IComparable right)
        {
            return left.CompareTo(right) == -1;
        }
    }
}