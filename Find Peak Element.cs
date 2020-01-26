public class Solution {
    public int FindPeakElement(int[] nums) {
            if (nums.Length == 1)
            {
                return 0;
            }
            if (nums.Length == 2)
            {
                return Array.IndexOf(nums, nums.Max());
            }
            int left = 0;
            int right = nums.Length - 1;

            int result = FindPeak(nums, left, right);
            return result;
    }
     private int FindPeak(int[] nums, int left, int right)
        {
            if (left == right)
            {
                int index = nums.Length - 1;
                if (left == index)
                {
                    if (nums[index] > nums[index - 1])
                    {
                        return index;
                    }
                }
                else
                {
                    int indexs = 0;
                    if (nums[indexs] > nums[indexs + 1])
                    {
                        return indexs;
                    }
                }
            }
            if (left < right)
            {
                int m = (right + left) / 2;
                if (m == 0)
                {
                    if (nums[m] > nums[m + 1])
                    {
                        return m;
                    }
                    return -1;
                }
                if (m == nums.Length - 1)
                {
                    if (nums[m] > nums[m - 1])
                    {
                        return m;
                    }
                    return -1;
                }
                if (nums[m] > nums[m - 1] && nums[m] > nums[m + 1])
                {
                    return m;
                }
                int res = FindPeak(nums, m + 1, right);
                if (res != -1)
                {
                    return res;
                }
                res = FindPeak(nums, left, m);
                if (res != -1)
                {
                    return res;
                }
            }
            return -1;
        }
}