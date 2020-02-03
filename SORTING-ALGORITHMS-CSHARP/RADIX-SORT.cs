using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixSort
{
  class RadixSort
    {
        public static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];
            for (i = 0; i < 10; i++)
                count[i] = 0;
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void radixsort(int[] arr, int n)
        {
            int m = getMax(arr, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }

        public static void print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        public static void Main()
        {
            int[] arr = { 30, 16, 5, 9, 2, 12, 4, 10 };
            int n = arr.Length;
            radixsort(arr, n);
            Console.WriteLine("Sorted Array: ");
            print(arr, n);

        }
    }
}
