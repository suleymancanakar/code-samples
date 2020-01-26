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

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr) {

            Dictionary<int, int> hash = new Dictionary<int, int>();
            int count = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int item = arr[i];
                if (!hash.ContainsKey(item))
                {
                    hash.Add(item, 1);
                    if (count == 0)
                    {
                        count = 1;
                    }
                }
                else
                {
                    int val = hash[item];
                    val++;
                    hash[item] = val;
                    if (val > count)
                    {
                        count = val;
                    }
                }
            }
            return arr.Length - count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
