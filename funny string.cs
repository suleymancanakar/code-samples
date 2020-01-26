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

    // Complete the funnyString function below.
    static string funnyString(string s) {

            int count = s.Length - 1;
            int i = 0;
            while (i < s.Length - 1 && count >= 0 )
            {
                int dif1 = s[i] - s[i + 1];
                if (dif1 < 0)
                {
                    dif1 = dif1 * -1;
                }
                int dif2 = s[count] - s[count - 1];
                if (dif2 < 0)
                {
                    dif2 = dif2 * -1;
                }
                if (dif1 != dif2)
                {
                    return "Not Funny";
                }
                i++;
                count--;
            }
            return "Funny";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            string result = funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
