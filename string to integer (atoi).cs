public class Solution {
    public int MyAtoi(string str) {
            str = str.Trim();
            string resultString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                var item = str[i];
                double a = char.GetNumericValue(item);
                if ((item == '+' || item == '-') && i == 0)
                {
                    resultString += item;
                }
                else if (a == -1)
                {
                    break;
                }
                else if (a > -1)
                {
                    resultString += item;
                }
            }
            if (string.IsNullOrEmpty(resultString) || resultString == "-" || resultString == "+")
            {
                return 0;
            }

            Int64 intValue;
            bool parsed = Int64.TryParse(resultString, out intValue);
            if (!parsed)
            {
                if (resultString.StartsWith("+") || !resultString.StartsWith("-"))
                {
                    return int.MaxValue;
                }
                return int.MinValue;
            }

            if (intValue > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (intValue < int.MinValue)
            {
                return int.MinValue;
            }
            return (int)intValue;
    }
}