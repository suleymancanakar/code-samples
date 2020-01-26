using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Sorting
    {
        static int partitiontest(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int index = low - 1;
            for (int i = low; i < high; i++)
            {
                if (arr[i] < pivot)
                {
                    index++;
                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                }
            }
            int temp1 = arr[index + 1];
            arr[index + 1] = arr[high];
            arr[high] = temp1;

            return index + 1;
        }
        public static void quicksorttest(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partItem = partitiontest(arr, low, high);

                quicksorttest(arr, low, partItem - 1);
                quicksorttest(arr, partItem + 1, high);
            }
        }
        // Merges two subarrays of arr[]. 
        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r] 
        static void merge(int[] arr, int l, int m, int r, out int count)
        {
            count = 0;
            // Find sizes of two subarrays to be merged 
            int n1 = m - l + 1;
            int n2 = r - m;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int a = 0; a < n1; ++a)
                L[a] = arr[l + a];
            for (int b = 0; b < n2; ++b)
                R[b] = arr[m + 1 + b];

            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                    count++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that sorts arr[l..r] using 
        // merge() 
        public static void mergeSort(int[] arr, int l, int r, out int count)
        {
            count = 0;
            if (l < r)
            {

                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                mergeSort(arr, l, m, out count);
                mergeSort(arr, m + 1, r, out count);

                // Merge the sorted halves 
                merge(arr, l, m, r, out count);
            }
        }

        /* This function takes last element as pivot, 
    places the pivot element at its correct
    position in sorted array, and places all
    smaller(smaller than pivot) to left of
   pivot and all greater elements to right
    of pivot */
        static int partition(int[] arr, int low,
                                       int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        public static void BucketSort()
        {
            double[] arr = new double[] { 0.78, 0.17, 0.39, 0.26, 0.72, 0.94, 0.21, 0.12, 0.23, 0.68 };
            List<double> sortedList = new List<double>();

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * 10 > max)
                {
                    max = (int)(arr[i] * 10);
                }
            }
            List<double>[] bucketArray = new List<double>[max + 1];
            for (int i = 0; i < bucketArray.Length; i++)
            {
                bucketArray[i] = new List<double>();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int index = (int)(arr[i] * 10);
                bucketArray[index].Add(arr[i]);
            }
            for (int i = 0; i < bucketArray.Length; i++)
            {
                var sortedBucketList = bucketArray[i].OrderBy(x => x).ToList();
                sortedList.AddRange(sortedBucketList);
            }
        }
    }
}
