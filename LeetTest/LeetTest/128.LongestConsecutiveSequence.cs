
LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });

int LongestConsecutive(int[] nums)
{
    // make sure that every number is unique
    var hashSet = new HashSet<int>(nums);

    int longest = 1;
    foreach (var num in hashSet)
    {
        if (!hashSet.Contains(num - 1))
        {
            int currentSequence = 1;

            while (hashSet.Contains(num + currentSequence))
                currentSequence++;

            longest = Math.Max(longest, currentSequence);
        }
    }

    return longest;
}