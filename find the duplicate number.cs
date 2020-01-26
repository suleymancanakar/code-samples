public class Solution {
    public int FindDuplicate(int[] nums) {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i ++)
            {
                int number = nums[i];
                if (list.Contains(number))
                {
                    return number;
                }
                list.Add(number);
            }
            return 0;
    }
}