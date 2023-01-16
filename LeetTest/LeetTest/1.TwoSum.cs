
TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 9);

int[] TwoSum(int[] nums, int target)
{
    if (nums.Length < 2)
        return new int[2];

    var dict = new Dictionary<int, int>(nums.Length);

    for (int i = 0; i < nums.Length; i++)
    {
        if (dict.TryGetValue(nums[i], out int indx))
            return new int[] { indx, i };
        else
            dict[target - nums[i]] = i;
    }

    return new int[2];
}