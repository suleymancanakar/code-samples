public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
            int lastIndex = nums.Length - 1;
            int index = 0;
            bool found = false;
            if (nums.Length == 1)
            {
                if (nums[0] == target)
                {
                    return new int[] { 0, 0 };
                }
                return new int[] { -1, -1 };
            }
            while (index <= lastIndex)
            {
                if (nums[index] == target && nums[lastIndex] == target)
                {
                    return new int[] { index, lastIndex };
                }
                else if (nums[index] == target)
                {
                    found = true;
                    lastIndex--;
                }
                else if (nums[lastIndex] == target)
                {
                    found = true;
                    index++;
                }
                else
                {
                    index++;
                    lastIndex--;
                }
            }
            if (found == false)
            {
                return new int[] { -1, -1 };
            }
            return new int[] { index, lastIndex };    
    }
}