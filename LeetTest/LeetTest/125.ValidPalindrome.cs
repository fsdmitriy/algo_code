
IsPalindrome("0P");
IsPalindrome("A man, a plan, a canal: Panama");
IsPalindrome("race a car");

bool IsPalindrome(string s)
{
    s = s.ToUpper();
    int left = 0, rigth = s.Length - 1;
    while (left < rigth)
    {
        if (!char.IsLetterOrDigit(s[left]))
        {
            left++;
        }
        else if (!char.IsLetterOrDigit(s[rigth]))
        {
            rigth--;
        }
        else
        {
            if (s[left] == s[rigth])
            {
                left++;
                rigth--;
            }
            else return false;
        }
    }

    return true;
}