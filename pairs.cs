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

    // Complete the pairs function below.
    static int pairs(int k, int[] arr) {

            int result = 0;
            int max = arr.Max();

            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                hash.Add(index, 1);
            }

            arr = arr.OrderBy(x => x).ToArray();
            for (int j = 0; j < arr.Length; j++)
            {
                int item = arr[j];
                if (item + k > max)
                {
                    break;
                }
                if (hash.ContainsKey(item + k))
                {
                    result++;
                }
            }

            return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = pairs(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
