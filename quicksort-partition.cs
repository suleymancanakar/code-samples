using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the quickSort function below.
    static int[] quickSort(int[] arr) {

            int low = 0;
            int high = arr.Length;
            if (low < high)
            {
                part(arr, low, high);
            }
            return arr;
    }

        static void part(int[] arr, int low, int high)
        {
            int pivot = arr[0];
            int i = low - 1;

            for (int k = low; k < high;k++ )
            {
                if (arr[k] < pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
                }
            }
            int pivotInd = Array.IndexOf(arr, pivot);
            int temp2 = arr[i + 1];
            arr[i + 1] = pivot;
            arr[pivotInd] = temp2;
        }
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = quickSort(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
