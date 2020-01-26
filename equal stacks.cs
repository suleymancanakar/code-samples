using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the equalStacks function below.
     */
    static int equalStacks(int[] h1, int[] h2, int[] h3) {

            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            Stack<int> s3 = new Stack<int>();
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = h1.Length - 1; i >= 0; i--)
            {
                int item = h1[i];
                s1.Push(item);
                sum1 += item;
            }
            for (int i = h2.Length - 1; i >= 0; i--)
            {
                int item = h2[i];
                s2.Push(item);
                sum2 += item;
            }
            for (int i = h3.Length - 1; i >= 0; i--)
            {
                int item = h3[i];
                s3.Push(item);
                sum3 += item;
            }

            while (sum1 > 0 && sum2 > 0 && sum3 > 0)
            {
                if (sum1 == sum2 && sum1 == sum3 && sum2 == sum3)
                {
                    return sum1;
                }

                int minNumber = Math.Min(sum1, Math.Min(sum2, sum3));

                while (sum1 > minNumber)
                {
                    int item1 = s1.Pop();
                    sum1 -= item1;
                }
                while (sum2 > minNumber)
                {
                    int item2 = s2.Pop();
                    sum2 -= item2;
                }
                while(sum3 > minNumber)
                {
                    int item3 = s3.Pop();
                    sum3 -= item3;
                }              
            }
            return 0;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] n1N2N3 = Console.ReadLine().Split(' ');

        int n1 = Convert.ToInt32(n1N2N3[0]);

        int n2 = Convert.ToInt32(n1N2N3[1]);

        int n3 = Convert.ToInt32(n1N2N3[2]);

        int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp))
        ;

        int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp))
        ;

        int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp))
        ;
        int result = equalStacks(h1, h2, h3);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
