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

    // Complete the minimumLoss function below.
    static int minimumLoss(long[] price) {
        
            Dictionary<long, int> hash = new Dictionary<long, int>();
            for (int j = 0; j < price.Length; j++)
            {
                hash.Add(price[j], j);
            }
            long[] orderedprice = price.OrderBy(x => x).ToArray();
            long minLoss = long.MaxValue;
            for (int i = 0; i < orderedprice.Length - 1;i++)
            {
                int bigIndex = hash[orderedprice[i + 1]];
                int smallIndex = hash[orderedprice[i]];
                //int bigIndex = Array.IndexOf(price, orderedprice[i + 1]);
                //int smallIndex = Array.IndexOf(price, orderedprice[i]);
                if (bigIndex > smallIndex)
                {
                    continue;
                }

                long dif = Math.Abs(orderedprice[i] - orderedprice[i + 1]);
                if (dif < minLoss)
                {
                    minLoss = dif;
                }
            }
            return (int)minLoss;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        long[] price = Array.ConvertAll(Console.ReadLine().Split(' '), priceTemp => Convert.ToInt64(priceTemp))
        ;
        int result = minimumLoss(price);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
