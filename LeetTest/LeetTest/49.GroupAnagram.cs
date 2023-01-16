using System.ComponentModel.DataAnnotations;

GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });


IList<IList<string>> GroupAnagrams(string[] strs)
{
	var result = new List<IList<string>>(1);

	var dict = new Dictionary<int[], List<string>>();

	for (int i = 0; i < strs.Length; i++)
	{
		var count = new int[26];

		for (int j = 0; j < strs[i].Length; j++)
		{
			count[strs[i][j] - 'a'] += 1;
		}

		if (!dict.ContainsKey(count))
			dict[count] = new List<string> { strs[i] };
		else
			dict[count].Add(strs[i]);
	}

	return result;
}