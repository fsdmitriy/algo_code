//int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
int[][] intervals = new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
int []interval = new int[] { 4,8 };

var result = Insert(intervals, interval);

foreach (var item in result)
{
    Console.WriteLine("[{0}, {1}]", item[0], item[1]);
}

int[][] Insert(int[][] intervals, int[] newInterval)
{
    var result = new List<int[]>();

    foreach (var curr in intervals)
    {
        if (newInterval[0] > curr[1])
        {
            result.Add(curr);
        }
        else if (newInterval[1] < curr[0])
        {
            result.Add(newInterval);
            newInterval = curr;
        }
        else
        {
            newInterval[0] = Math.Min(curr[0], newInterval[0]);
            newInterval[1] = Math.Max(curr[1], newInterval[1]);
        }
    }

    result.Add(newInterval);

    return result.ToArray();
}