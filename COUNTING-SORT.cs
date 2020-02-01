using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingSort
{

public class CountingSort  
{  
 public static void Main()  
    {  
int[] array = new int[8]
{
   30, 16, 5, 9, 2, 12, 4, 10
};
 
    Console.WriteLine("Array before sorting:");
           foreach (int aa in array)                       
           Console.Write(aa + " "); 

    int[] sortedArray = new int[array.Length];
 
    // find smallest and largest value
    int minVal = array[0];
    int maxVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minVal) minVal = array[i];
        else if (array[i] > maxVal) maxVal = array[i];
    }
 
    // init array of frequencies
    int[] counts = new int[maxVal - minVal + 1];
 
    // init the frequencies
    for (int i = 0; i < array.Length; i++)
    {
        counts[array[i] - minVal]++;
    }
 
    // recalculate
    counts[0]--;
    for (int i = 1; i < counts.Length; i++)
    {
        counts[i] = counts[i] + counts[i - 1];
    }
 
    // Sort the array
    for (int i = array.Length - 1; i >= 0; i--)
    {
        sortedArray[counts[array[i] - minVal]--] = array[i];
    }
 
  Console.WriteLine("\n\nArray after sorting:");
           foreach (int aa in sortedArray)                       
           Console.Write(aa + " "); 
  Console.Write("\n");            
                   
}
}


}
