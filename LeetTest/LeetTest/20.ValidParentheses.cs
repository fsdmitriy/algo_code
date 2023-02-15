
IsValid("{[]}");
IsValid("()");
IsValid("()[]{}");
IsValid("(]");

bool IsValid(string s)
{
    if (s.Length <= 1)
        return false;

    var stack = new Stack<char>();
    var st = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] is '(' or '{' or '[')
        {
            stack.Push(s[i]);
        }
        else
        {
            if (!stack.TryPop(out char val))
                return false;

            switch (val)
            {
                case '(' when s[i] is ')':
                case '[' when s[i] is ']':
                case '{' when s[i] is '}':
                    continue;
                default: return false;
            }

            //if (pairs.ContainsKey(s[i]))
            //{
            //    stack.Push(s[i]);
            //}
            //else if (stack.Count == 0 || s[i] != pairs[stack.Pop()])
            //{
            //    return false;
            //}
        }
    }

    return stack.Count == 0;
}