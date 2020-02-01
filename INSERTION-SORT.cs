using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
 class InsertionSort { 
   void sort(int[] arr) 
    { 
        int n = arr.Length; 
        for (int i = 1; i < n; ++i) { 
            int key = arr[i]; 
            int j = i - 1; 
           while (j >= 0 && arr[j] > key) { 
               arr[j + 1] = arr[j]; 
                j = j - 1; 
            } 
            arr[j + 1] = key; 
        } 
    } 
    static void printArray(int[] arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n; ++i) 
            Console.Write(arr[i] + " "); 
              Console.Write("\n"); 
    } 

    public static void Main() 
    { 
        int[] arr = { 30, 16, 5, 9, 2, 12, 4, 10 };
        Console.WriteLine("Unsorted Array:");
        printArray(arr);
        InsertionSort ob = new InsertionSort(); 
        ob.sort(arr);
        Console.WriteLine("Sorted Array;");
        printArray(arr); 

    } 
} 
}
