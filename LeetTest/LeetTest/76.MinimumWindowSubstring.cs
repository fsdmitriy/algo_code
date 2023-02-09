MinWindow("aa", "aa");
MinWindow("bba", "ab");
MinWindow("bdab", "ab");
MinWindow("ADOBECODEBANC", "ABC");
MinWindow("a", "a");
MinWindow("a", "aa");

string MinWindow(string s, string t)
{
    if (string.IsNullOrEmpty(t))
        return "";

    var tDict = new Dictionary<char, int>();
    var window = new Dictionary<char, int>();

    foreach (var ch in t)
    {
        if (tDict.ContainsKey(ch))
            tDict[ch]++;
        else
        {
            tDict[ch] = 1;
            window[ch] = 0;
        }
    }

    int[] result = new int[] { -1, -1 };

    int startPoint = 0, need = tDict.Count, have = 0, resultLength = int.MaxValue, sLength = s.Length;

    for (int endPoint = 0; endPoint < sLength; endPoint++)
    {
        var c = s[endPoint];

        if (window.ContainsKey(c))
            window[c]++;

        if (tDict.ContainsKey(c) && window[c] == tDict[c]) have++;

        while (have == need)
        {
            var windowSize = endPoint - startPoint + 1;
            if (windowSize < resultLength)
            {
                resultLength = windowSize;
                result[0] = startPoint;
                result[1] = endPoint;
            }

            if (window.ContainsKey(s[startPoint]))
                window[s[startPoint]]--;

            if (tDict.ContainsKey(s[startPoint]) && window[s[startPoint]] < tDict[s[startPoint]])
            {
                have--;
            }

            startPoint++;
        }
    }

    if (result[0] == -1)
        return "";
    else
        return s.Substring(result[0], result[1] - result[0] + 1);
}