public class Solution {
    public string LargestNumber(int[] nums) {
        
        
            var strNums = nums.Select(n => n.ToString()).ToArray();
            Array.Sort(strNums, (a, b) => string.Compare(b + a, a + b, StringComparison.Ordinal));

            bool leadingZero = true;
            var sb = new StringBuilder();
            foreach (var num in strNums)
            {
                leadingZero = (leadingZero && num == "0");
                if (leadingZero && sb.Length > 0 && sb[sb.Length - 1] == '0')
                {
                    continue;
                }
                sb.Append(num);
            }
            return sb.ToString();
    }
}