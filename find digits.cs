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

    // Complete the findDigits function below.
    static int findDigits(int n) {

            int result = 0;
            List<int> divisors = new List<int>();
            string str = n.ToString();
            for (int i = 0; i < str.Length;i++)
            {
                int val = int.Parse(str[i].ToString());
                if (val != 0)
                {
                    divisors.Add(val);
                }
            }
            foreach (var div in divisors)
            {
                if (n % div == 0)
                {
                    result++;
                }
            }
            return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
