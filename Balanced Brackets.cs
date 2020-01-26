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

    // Complete the isBalanced function below.
    static string isBalanced(string s) {

            int length = s.Length;
            if (length % 2 == 1) { return "NO"; }

            Dictionary<char, char> hash = new Dictionary<char, char>()
            {
                {'[', ']'},
                {'(', ')'},
                {'{', '}'}
            };
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < length; i++)
            {
                char item = s[i];
                if (item == '{' || item == '[' || item == '(')
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return "NO";
                    }
                    char value = stack.Pop();
                    var hashItem = hash[value];
                    if (item != hashItem)
                    {
                        return "NO";
                    }
                }
            }
             return stack.Count == 0 ? "YES" : "NO" ;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
