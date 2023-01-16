
//int[] nums = { 1, 1, 1 };
int[] nums = { 3, 4, 7, 2, -3, 1, 4, 2 };
//int k = 2;
int k = 7;

var res = SubarraySum(nums, k);

int SubarraySum(int[] nums, int k)
{
    int subsCount = 0, sum = 0;
    var dict = new Dictionary<int, int>() { { 0, 1 } };

    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
        if (dict.TryGetValue(sum - k, out int appeared))
        {
            subsCount += appeared;
        }

        dict[sum] = dict.GetValueOrDefault(sum) + 1;
    }

    return subsCount;
}