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

    // Complete the absolutePermutation function below.
    static int[] absolutePermutation(int n, int k) {

            int total = 0;
            int[] arr = new int[n];
            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    int val = i + k;
                    if (val <= n)
                    {
                       arr[i - 1] = val;
                        hash.Add(val, 1);
                        continue;
                    }
                }
                else
                {
                    int val2 = i - k;
                    if (hash.ContainsKey(val2))
                    {
                        val2 = i + k;
                    }
                    if (val2 <= n)
                    {
                        arr[i - 1] = val2;
                        hash.Add(val2, 1);
                        continue;
                    }
                }
                return new int[] { -1 };
            }
            return arr;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] result = absolutePermutation(n, k);

            textWriter.WriteLine(string.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
