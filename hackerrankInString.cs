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

class Solution
{

    // Complete the hackerrankInString function below.
    static string hackerrankInString(string s)
    {

        int count = 0;
        char[] hackerrankArray = "hackerrank".ToCharArray();

        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char item = s[i];
            if (j == s.Length || j == 10)
            {
                break;
            }
            if (item == hackerrankArray[j])
            {
                count++;
                j++;
            }
        }
        if (count == 10)
        {
            return "YES";
        }
        return "NO";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = hackerrankInString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
