public class Solution {
    public string Convert(string s, int numRows) {
            if (s.Length <= numRows || numRows == 1)
            {
                return s;
            }
            int mostDepth = (numRows - 1) * 2;
            Dictionary<int, List<int>> matchList = new Dictionary<int, List<int>>();
            int j = 0;
            int k = mostDepth;
            for (int i = 0; i <= mostDepth; i += 2)
            {
                List<int> vs = new List<int>();
                vs.Add(k);
                vs.Add(i);
                matchList.Add(j, vs);
                k = k - 2;
                j++;
            }
            Dictionary<int, List<char>> pairs = new Dictionary<int, List<char>>();
            int pairsIndex = 0;
            foreach (var match in matchList)
            {
                bool addFirst = true;
                bool addSecond = false;

                int indexKey = match.Key;
                List<int> indexValue = match.Value;
                if (indexValue[0] == 0)
                {
                    indexValue = new List<int>() { indexValue[1] };
                }
                else if (indexValue[1] == 0)
                {
                    indexValue = new List<int>() { indexValue[0] };
                }
                List<char> arr = new List<char>();
                while (indexKey <= s.Length - 1)
                {
                    arr.Add(s[indexKey]);
                    if (indexValue.Count == 1)
                    {
                        indexKey = indexKey + indexValue[0];
                        continue;
                    }
                    else if (addFirst)
                    {
                        indexKey = indexKey + indexValue[0];
                        addSecond = true;
                        addFirst = false;
                    }
                    else if (addSecond)
                    {
                        indexKey = indexKey + indexValue[1];
                        addFirst = true;
                        addSecond = false;
                    }
                }
                pairs.Add(pairsIndex, arr);
                pairsIndex++;
            }
            string result = "";
            foreach (List<char> val in pairs.Values)
            {
                string ss = new string(val.ToArray());
                result += ss;
            }
            return result;     
    }
}