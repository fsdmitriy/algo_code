
GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
GroupAnagrams(new string[] { "" });
GroupAnagrams(new string[] { "a" });


IList<IList<string>> GroupAnagrams(string[] strs)
{
    var dict = new Dictionary<string, IList<string>>();

	for (int i = 0; i < strs.Length; i++)
	{
		char[] characters = strs[i].ToCharArray();
		Array.Sort(characters);
		var sortedString = new string(characters);
        if (dict.TryGetValue(sortedString, out IList<string> group))
		{
			group.Add(strs[i]);
        }
		else
		{
			dict.Add(sortedString, new List<string> { strs[i] });
        }	
	}

	return dict.Values.ToList();
}