public class Solution {
    public string LongestPalindrome(string s) {
        return LongPal(s);
    }
        private static string LongPal(string s)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            if (s.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int k = i - 1; k <= i; k++)
                {
                    int firstIndex = k;
                    int lastIndex = i + 1;
                    int length = 0;
                    bool palindrome = true;
                    while (firstIndex >= 0 && lastIndex <= s.Length - 1)
                    {
                        if (s[firstIndex] == s[lastIndex])
                        {
                            length += 2;
                            firstIndex--;
                            lastIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (length == 0)
                    {
                        int temp = i;
                        while (temp < s.Length - 1 && s[temp] == s[temp + 1])
                        {
                            length += 1;
                            temp++;
                        }
                        int total = k == i ? length : length + 1;
                        if (!hash.ContainsKey(total))
                        {
                            hash.Add(total, i);
                        }
                    }
                    else
                    {
                        int total = k == i ? length : length + 1;
                        if (!hash.ContainsKey(total))
                        {
                            hash.Add(total, firstIndex + 1);
                        }
                    }
                }
            }
            
            int lengthOfmax =  hash.Keys.Max();
            int lengthOfIndex = hash[lengthOfmax];

            return s.Substring(lengthOfIndex, lengthOfmax);
        }
}