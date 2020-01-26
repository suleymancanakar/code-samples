public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
            nums1 = nums1.OrderBy(x => x).ToArray();
            nums2 = nums2.OrderBy(x => x).ToArray();

            List<int> sectionList = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                int item = nums1[i];
                int left = 0;
                int right = nums2.Length - 1;
                while (left <= right)
                {
                    int m = (left + right) / 2;
                    if (nums2[m] == item)
                    {
                        sectionList.Add(item);
                        break;
                    }
                    else if (nums2[m] < item)
                    {
                        left = m + 1;
                    }
                    else
                    {
                        right = m - 1;
                    }
                }
            }
            return sectionList.Distinct().ToArray();
    }
}