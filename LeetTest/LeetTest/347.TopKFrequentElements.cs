using System.Collections.Generic;

TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
TopKFrequent(new int[] { 1 }, 1);

// Bucket sort algoritm
int[] TopKFrequent(int[] nums, int k)
{
	var dict = new Dictionary<int, int>();

	for (int i = 0; i < nums.Length; i++)
	{
		dict.TryGetValue(nums[i], out int count);

		dict[nums[i]] = ++count;
	}

	var bucket = new List<int>[nums.Length + 1];

	foreach (var keyValuePair in dict)
	{
		if (bucket[keyValuePair.Value] == null)
			bucket[keyValuePair.Value] = new List<int>();

		bucket[keyValuePair.Value].Add(keyValuePair.Key);
	}

	var result = new int[k];
	int indx = 0;

	for (int i = bucket.Length - 1; i > 0; i--)
	{
		if (bucket[i]!=null && bucket[i].Count > 0)
		{
			for (int j = 0; j < bucket[i].Count; j++)
			{
				result[indx++] = bucket[i][j];

				if (indx == k)
					return result;
			}
		}
	}

	return result;
}