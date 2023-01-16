bool IsAnagram(string s, string t)
{

    if (s.Length != t.Length) return false;

    int[] c = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        int spot1 = s[i] - 'a';
        int spot2 = t[i] - 'a';

        c[spot1]++;
        c[spot2]--;
    }

    for (int i = 0; i < c.Length; i++)
    {
        if (c[i] != 0)
        {
            return false;
        }
    }

    return true;
}