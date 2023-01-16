//int[] nums = new int[] {-2, -1, -1, 1, 1, 2, 2};
//int target = 0;

int[] nums = new int[] { -1000000000, -1000000000, 1000000000, -1000000000, -1000000000 };
int target = 294967296;

var result = FourSum(nums, target);

Console.WriteLine(FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0));

IList<IList<int>> FourSum(int[] nums, int target)
{
    Array.Sort(nums);

    return K_Sum(nums, target, 0, 4);
}

IList<IList<int>> K_Sum(int[] nums, long target, int start, int k)
{
    var result = new List<List<int>>();

    if (start == nums.Length)
        return result.Select(a => a.ToArray()).ToArray();

    long average_val = target / k;

    if (nums[start] > average_val || average_val > nums[nums.Length - 1])
        return result.Select(a => a.ToArray()).ToArray();

    if (k == 2)
    {
        return TwoSum(nums, target, start);
    }

    for (int i = start; i < nums.Length; i++)
    {
        if (i == start || nums[i - 1] != nums[i])
        {
            foreach (IList<int> subset in K_Sum(nums, target - nums[i], i + 1, k - 1))
            {
                result.Add(new List<int>() { nums[i] });
                result[result.Count - 1].AddRange(subset);
            }
        }
    }

    return result.Select(a => a.ToArray()).ToArray();

}

IList<IList<int>> TwoSum(int[] nums, long target, int start)
{
    var result = new List<int[]>();
    int lo = start, hi = nums.Length - 1;

    while (lo < hi)
    {
        int currSum = nums[lo] + nums[hi];
        if (currSum < target || (lo > start && nums[lo] == nums[lo - 1]))
        {
            ++lo;
        }
        else if (currSum > target || (hi < nums.Length - 1 && nums[hi] == nums[hi + 1]))
        {
            --hi;
        }
        else
        {
            result.Add(new int[] { nums[lo++], nums[hi--] });
        }
    }

    return result.ToArray();
}
