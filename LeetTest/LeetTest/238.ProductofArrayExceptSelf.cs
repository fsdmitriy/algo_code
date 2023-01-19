
ProductExceptSelf(new int[] { 1, 2, 3, 4 });


int[] ProductExceptSelf(int[] nums)
{
    int n = nums.Length;

    int[] result = new int[n];
    result[0] = 1;

    for (int i = 1; i < n; i++)
    {
        result[i] = result[i-1]*nums[i - 1];
    }

    int prod_rigth = nums[n - 1];

    for (int i = n-2; i >=0; i--)
    {
        result[i] *= prod_rigth;
        prod_rigth *= nums[i];
    }

    return result;
}

int[] ProductExceptSelfTwoPostFixPrefix(int[] nums)
{
    int prefix = 1, postfix = 1;

    var res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = prefix;
        prefix *= nums[i];
    }

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        res[i] *= postfix;
        postfix *= nums[i];
    }

    return res;
}