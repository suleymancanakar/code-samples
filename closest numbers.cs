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

    // Complete the closestNumbers function below.
    static int[] closestNumbers(int[] arr) {

            arr = arr.OrderBy(x => x).ToArray();
            Dictionary<int, List<int>> hash = new Dictionary<int, List<int>>();
            int closest = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int difference = Math.Abs(arr[i] - arr[i + 1]);
                if (!hash.ContainsKey(difference))
                {
                    hash.Add(difference, new List<int>() { arr[i], arr[i + 1] });
                }
                else
                {
                    hash[difference].AddRange(new List<int>() { arr[i], arr[i + 1] });
                }
                if (difference < closest)
                {
                    closest = difference;
                }
            }
            var result = hash[closest];
            return result.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = closestNumbers(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
