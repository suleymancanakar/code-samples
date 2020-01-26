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

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice) {
       
            int[] resultArray = new int[alice.Length];
            for (int j = 0; j < alice.Length; j++)
            {
                resultArray[j] = 1;
            }

            scores = scores.Distinct().ToArray();
            int index = scores.Length - 1;
            int aliceLength = alice.Length;
            int k = 0;
            while (index >= 0 && k != aliceLength)
            {
                if (alice[k] > scores[index])
                {
                    index--;
                    continue;
                }
                else if (alice[k] == scores[index])
                {
                    resultArray[k] = index + 1;
                    k++;
                }
                else
                {
                    resultArray[k] = index + 2;
                    k++;
                }
            }

            return resultArray;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
