public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
            List<char> temp = new List<char>();
            int longestLength = 0;
            for (int i = 0; i < s.Length; i ++)
            {
                char item = s[i];
                temp.Add(item);
                for (int j = i + 1; j < s.Length; j++)
                {
                    char item2 = s[j];
                    if (!temp.Contains(item2))
                    {
                        temp.Add(item2);
                    }
                    else
                    {
                        if (temp.Count > longestLength)
                        {
                            longestLength = temp.Count;
                        }
                        temp.Clear();
                        break;
                    }
                }
                if (temp.Count > longestLength)
                {
                    longestLength = temp.Count;
                }
                temp.Clear();
            }
            return longestLength; 
    }
}