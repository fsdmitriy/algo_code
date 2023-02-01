
ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
ThreeSum(new int[] { 0, 1, 1 });
ThreeSum(new int[] { 0, 0, 0 });
ThreeSum(new int[] { -2, 0, 0, 2, 2 });
ThreeSum(new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 });

IList<IList<int>> ThreeSum(int[] nums)
{
	var result = new List<IList<int>>();

	if (nums.Length < 3)
		return result;
	//O(nLog n)
	Array.Sort(nums);

	
	for (int i = 0; i < nums.Length; i++)
	{
		if (i != 0 && nums[i] == nums[i - 1])
			continue;

		int j = i + 1, k = nums.Length - 1;

		while (j < k)
		{
			var sum = nums[i] + nums[j] + nums[k];
			if (sum == 0)
			{
				result.Add(new int[] { nums[i], nums[j], nums[k] });
				while (j < k && nums[k] == nums[k - 1]) k--;
				j++;
				k--;
			}
			else if (sum > 0)
			{
				k--;
			}
			else
			{
				j++;
			}
		}
	}
	//O(n^2)
	return result;
}