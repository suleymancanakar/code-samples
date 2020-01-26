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

    // Complete the timeInWords function below.
    static string timeInWords(int h, int m) {

            string result = "";
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {13, "thirteen" },
                {14, "fourteen" },
                {15, "quarter" },
                {16, "sixteen" },
                {17, "seventeen" },
                {18, "eighteen" },
                {19, "nineteen" },
                {20, "twenty" },
                {21, "twenty one" },
                {22, "twenty two" },
                {23, "twenty three" },
                {24, "twenty four" },
                {25, "twenty five" },
                {26, "twenty six" },
                {27, "twenty seven" },
                {28, "twenty eight" },
                {29, "twenty nine" },
                {30, "half past" },
            };

            string hour = dict[h];
            if (m == 00)
            {
                return hour + " o' clock";
            }
            string minutes = "";
            if (m < 30)
            {
                if (m == 15)
                {
                    minutes = "quarter past ";
                }
                else
                {
                    minutes += dict[m] + " minute";
                    if (m >= 10)
                    {
                        minutes += "s";
                    }
                    minutes += " past ";
                }
            }
            else if (m == 30)
            {
                return "half past " + hour;
            }
            else
            {
                hour = dict[h + 1];
                int val = 60 - m;
                if (val == 15)
                {
                    minutes = "quarter to ";
                }
                else
                {
                    minutes += dict[val] + " minute";
                    //if (val >= 10)
                    //{
                        minutes += "s";
                    //}
                    minutes += " to ";
                }
            }

            result = minutes + hour;
            return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine());

        int m = Convert.ToInt32(Console.ReadLine());

        string result = timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
