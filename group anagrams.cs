public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();

            List<List<string>> n = new List<List<string>>();
            
            
            List <List<string>> returnList = new List<List<string>>();
            if (strs == null || strs.Length == 0)
            {
                return null;
            }

            for (int i = 0; i < strs.Length; i++)
            {
                string selectedString = strs[i];
                int[] arr = new int[256];
                int c = 0;
                int b = 1;
                for (int j = 0; j < selectedString.Length; j++)
                {
                    c += selectedString[j];
                    b = b * selectedString[j];
                }               
                if (!dic.ContainsKey(c + b))
                {
                    var lst = new List<string>{ selectedString };
                    dic.Add(c + b, lst);
                }
                else
                {
                    List<string> lst = dic[c + b];
                    lst.Add(selectedString);
                    dic[c + b] = lst;
                }
            }
            int index = 0;
            var st = new List<string>();
            foreach (var item in dic.Values)
            {

                n.Add(item);
            }
            return n.ToArray();  
    }
}