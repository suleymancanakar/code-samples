public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
              int minDifference = int.MaxValue;
            List<int> numberVersions = new List<int>();
            for (int i = 0; i < timePoints.Count; i++)
            {
                string item = timePoints[i];
                var itemArr = item.Split(':');
                int hour = int.Parse(itemArr[0]);
                int min = int.Parse(itemArr[1]);

               // if (hour == 0)
                //{
                      numberVersions.Add((24 + hour)* 100 + min);
               // }
                int number = hour * 100 + min;
                numberVersions.Add(number);
            }
            numberVersions = numberVersions.OrderByDescending(x => x).ToList();
            for (int j = 0; j < numberVersions.Count - 1; j++)
            {
                int firstHour = numberVersions[j];
                int hour = firstHour / 100;
                int minute = firstHour % 100;
    
                int secoundHour = numberVersions[j  + 1];
                int hour2 = secoundHour / 100;
                int minute2 = secoundHour % 100;

                int difference = 0;
                int minuteDiff = minute - minute2;
                if (minuteDiff < 0)
                {
                    minuteDiff += 60;
                    if (hour != hour2)
                    {
                        minuteDiff += (hour - hour2 - 1) * 60;
                    }
                }
                else
                {
                    minuteDiff += (hour - hour2) * 60;
                }
                if (minuteDiff < minDifference)
                {
                    minDifference = minuteDiff;
                }
            }
            return minDifference;
    }
}