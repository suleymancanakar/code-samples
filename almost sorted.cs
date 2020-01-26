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

    // Complete the almostSorted function below.
    static void almostSorted(int[] arr) {

                        int[] arr2 = arr.OrderBy(x => x).ToArray();
            List<int> lst = new List<int>();
            bool possible = true;

            for (int i = 0; i < arr.Length; i ++)
            {
                if (arr[i] != arr2[i])
                {
                    lst.Add(i + 1);
                }
            }
            if (lst.Count == 2)
            {
                Console.WriteLine("yes");
                Console.WriteLine("swap " + lst[0].ToString() + " " + lst[1].ToString());
            }

            else if (lst.Count > 2)
            {
                int firstIndex = lst[0] - 1;
                int lastIndex = lst[lst.Count - 1] - 1;
                for (int k = firstIndex; k <= lastIndex; k++)
                {
                    if (arr[k] != arr2[lastIndex])
                    {
                        possible = false;
                        break;
                    }
                    lastIndex--;
                }
                if (possible)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("reverse " + lst[0].ToString() + " " + lst[lst.Count - 1].ToString());
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        almostSorted(arr);
    }
}
