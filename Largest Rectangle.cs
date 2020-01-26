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

    // Complete the largestRectangle function below.
    static long largestRectangle(int[] h) {

            long result = 0;
            
            int length = h.Length ;
            Stack<int> stack = new Stack<int>();
            Stack<int> stackSecond = new Stack<int>();

            for (int i = 0; i < length; i++)
            {
                int item = h[i];
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    int left = h[j];
                    if (left >= item)
                    {
                        count++;
                        continue;
                    }
                    break;
                }
                for (int k = i + 1; k < length; k++)
                {
                    int right = h[k];
                    if (right >= item)
                    {
                        count++;
                        continue;
                    }
                    break;
                }
                int total = item * count;
                if (total > result)
                {
                    result = total;
                }
            }

            return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        long result = largestRectangle(h);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
