public class Solution {
    public int SingleNonDuplicate(int[] nums) {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int left = 0;
            int right = nums.Length - 1;

            int result = SingleNonDup(nums, left, right);
            return result;
    }
    private int SingleNonDup(int[] nums, int left , int right)
        {
            if (left == right)
            {
                int index = nums.Length - 1;
                if (left == index)
                {
                    if (nums[index] != nums[index - 1])
                    {
                        return nums[index];
                    }
                }
                else
                {
                    int indexs = 0;
                    if (nums[indexs] != nums[indexs + 1])
                    {
                        return nums[indexs];
                    }
                }
            }
            if (left < right)
            {
                int m =( right + left ) / 2;
                if (m == 0)
                {
                    if (nums[m] != nums[m + 1])
                    {
                        return nums[m];
                    }
                    return -1;
                }
                if (m == nums.Length - 1)
                {
                    if (nums[m] != nums[m - 1])
                    {
                        return nums[m];
                    }
                    return -1;
                }
                if (nums[m] != nums[m - 1] && nums[m] != nums[m+1])
                {
                    return nums[m];
                }
                int res = SingleNonDup(nums, m + 1, right);
                if (res != -1)
                {
                    return res;
                }
                res = SingleNonDup(nums, left, m);
                if (res != -1)
                {
                    return res;
                }
            }
            return -1;
        }
}