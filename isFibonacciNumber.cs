using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    // Complete the solve function below.
    static string solve(long n) {

            Int64[] fib = new Int64[3000];
            Int64 res = fibonacci(fib.Length - 1, fib);
            if (fib.Contains(n))
            {
                return "IsFibo";
            }
            return "IsNotFibo";
    }
        static long fibonacci(int i, Int64[] fib)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;

            if (fib[i] != 0) return fib[i]; // Return cached result.
            fib[i] = fibonacci(i - 1, fib) + fibonacci(i - 2, fib); // Cache result
            return fib[i];
        }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            long n = Convert.ToInt64(Console.ReadLine());

            string result = solve(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
