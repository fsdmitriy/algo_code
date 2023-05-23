
MergeArrays(new int[][] { new int[] { 1, 2 }, new int[] { 2, 5 }, new int[] { 5, 8 } });
MergeArrays(new int[][] { new int[] { 1, 5 }, new int[] { 2, 5 }, new int[] { 5, 8 } });
MergeArrays(new int[][] { new int[] { 1, 8 }, new int[] { 2, 5 }, new int[] { 5, 8 } });
MergeArrays(new int[][] { new int[] { 1, 2 }, new int[] { 2, 6 }, new int[] { 5, 8 }, new int[] { 8, 10 } });
MergeArrays(new int[][] { new int[] { 1, 2 }, new int[] { 4, 6 }, new int[] { 5, 8 }, new int[] { 8, 10 } });

int[][] MergeArrays(int[][] arr)
{
    var currPair = arr[0];
    int i = 1;

    while (i < arr.Length)
    {
        if (currPair[1] != arr[i][0] || currPair[1] < arr[i][0])
        {
            var diff = arr[i][1] - arr[i][0];
            arr[i][0] = currPair[1];
            arr[i][1] = arr[i][0] + diff;
        }

        currPair = arr[i++];
    }

    return arr;
}