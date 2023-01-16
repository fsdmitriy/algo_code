int[] nums = { 2, 1, -1 };

var pivot = PivotIndex(nums);

int PivotIndex(int[] nums)
{
    int sum = 0;

    foreach (var num in nums) sum += num;

    for (int i = 0; i < nums.Length; i++)
    {
        if (sum - (i == 0 ? 0 : nums[i - 1]) - nums[i] == (i == 0 ? 0 : nums[i - 1]))
            return i;

        nums[i] += nums[i - 1];
    }

    return -1;
}