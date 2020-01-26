using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CrackingTheCodingInterview
    {
        // pg 121 => You are given two sorted arrays, A and B, where A has a large enough buffer at
        // the end to hold B.Write a method to merge B into A in sorted order.
        // Solution => pg 360

        //Note that you don't need to copy the contents of A after running out of elements in B.
        //They are already in place.
        static void MergeBintoA()
        {
            int[] A = new int[] { 1, 3, 5, 7, 8, 0, 0, 0, 0, 0 };
            int[] B = new int[] { 2, 4, 6, 9, 10 };

            int lastIndexA = A.Length - 1;
            int lastIndexB = A.Length - 1;
            int lastIndexFinal = lastIndexA + lastIndexB - 1;

            while(lastIndexA >= 0 && lastIndexB >= 0)
            {
                if (A[lastIndexA] > B[lastIndexB])
                {
                    A[lastIndexFinal] = A[lastIndexA];
                    lastIndexA--;
                }
                else
                {
                    A[lastIndexFinal] = B[lastIndexB];
                    lastIndexB--;
                }
                lastIndexFinal--;
            }
            while (lastIndexB >= 0)
            {
                A[lastIndexFinal] = B[lastIndexB];
                lastIndexB--;
                lastIndexFinal--;
            }
        }
    }
}
