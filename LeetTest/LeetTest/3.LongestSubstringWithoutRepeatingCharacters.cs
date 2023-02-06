LengthOfLongestSubstring(" ");
LengthOfLongestSubstring("aab");
LengthOfLongestSubstring("abcabcbb");
LengthOfLongestSubstring("bbbbb");
LengthOfLongestSubstring("pwwkew");

int LengthOfLongestSubstring(string s)
{
    if (s.Length == 1)
        return s.Length;

    var set = new HashSet<char>();

    int p1 = 0; int p2 = 0, result = 0;
    while (p2 < s.Length)
    {
        if (set.Add(s[p2]))
        {
            p2++;
        }
        else
        {     
            set.Remove(s[p1]);
            p1++;
        }

        result = Math.Max(result, p2-p1);
    }

    return result;
}