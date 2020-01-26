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

    // Complete the minimumDistances function below.
    static int minimumDistances(int[] a) {

            bool found = false;
            int min = int.MaxValue;
            Dictionary<int, List<int>> hash = new Dictionary<int, List<int>>();
            for (int i = 0; i < a.Length; i++)
            {
                int item = a[i];
                if (!hash.ContainsKey(item))
                {
                    hash.Add(item, new List<int>() { i });
                }
                else
                {
                    found = true;

                    var list = hash[item];
                    int difference = i - list[0];
                    if (difference < min)
                    {
                        min = difference;
                    }
                }
            }
            if (found)
            {
                return min;
            }
            return -1;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
