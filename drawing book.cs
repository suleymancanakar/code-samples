using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        /*
         * Write your code here.
         */
            int i = 1;
            int count1 = 0, count2 = 0;
            bool isOddNum = n % 2 == 1;

            while (i < p)
            {
                i += 2;
                count1++;

            }
            while (p < n)
            {
                if (isOddNum && p == n - 1)
                {
                    break;
                }
                n -= 2;
                count2++;
            }
            return Math.Min(count1, count2);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
