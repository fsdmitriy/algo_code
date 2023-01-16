using System.Collections.Generic;

//int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
int[][] intervals = new int[][] { new int[] { 1, 4 }, new int[] { 4, 5 } };

var result = Merge(intervals);

foreach (var item in result)
{
    Console.WriteLine("[{0}, {1}]", item[0], item[1]);
}

int[][] Merge(int[][] intervals)
{
    var result = new List<int[]>();

    if (intervals.Length < 2)
        return intervals;

    Array.Sort(intervals, (int[] a1, int[] a2)=> a1[0].CompareTo(a2[0]) );

    int[] currInteval = intervals[0];

    for (int i = 1; i < intervals.Length; i++)
    {
        if (currInteval[1] >= intervals[i][0])
        {
            currInteval[1] = Math.Max(currInteval[1], intervals[i][1]);
        }
        else
        {
            result.Add(currInteval);
            currInteval = intervals[i];
        }
    }

    result.Add(currInteval);

    return result.ToArray();
}