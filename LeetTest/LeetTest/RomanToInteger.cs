var s = "MCMXCIV";
RomanToInt(s);

int RomanToInt(string s)
{
    var arr = new int[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i])
        {
            case 'I': arr[i] = 1; break;
            case 'V': arr[i] = 5; break;
            case 'X': arr[i] = 10; break;
            case 'L': arr[i] = 50; break;
            case 'C': arr[i] = 100; break;
            case 'D': arr[i] = 500; break;
            case 'M': arr[i] = 1000; break;
        };
    }

    int sum = arr[arr.Length - 1];

    for (int i = arr.Length - 2; i >= 0; i--)
    {
        if (arr[i + 1] > arr[i])
        {
            sum -= arr[i];
        }
        else
        {
            sum += arr[i];
        }
    }

    return sum;
}