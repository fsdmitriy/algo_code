
CharacterReplacement("ABAB", 2);
CharacterReplacement("AABABBA", 1);

int CharacterReplacement(string s, int k)
{
    var dict = new Dictionary<char, int>();
    int result = 0, leftPoint = 0, rigthPoint = 0, currMaxFriquent = 0;

    while (rigthPoint < s.Length)
    {
        dict.TryGetValue(s[rigthPoint], out int val);

        dict[s[rigthPoint]] = ++val;

        currMaxFriquent = Math.Max(currMaxFriquent, dict[s[rigthPoint]]);

        if (rigthPoint - leftPoint + 1 - currMaxFriquent > k)
        {
            dict[s[leftPoint]]--;
            currMaxFriquent--;
            leftPoint++;
        }

        result = Math.Max(result, rigthPoint - leftPoint + 1);

        rigthPoint++;
    }

    return result;
}