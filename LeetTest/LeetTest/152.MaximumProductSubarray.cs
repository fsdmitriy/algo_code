
MaxProduct(new int[] { 2, 3, -2, 4 });
MaxProduct(new int[] { -1, 0, -2 });
MaxProduct(new int[] { -4, -3, -2 });

int MaxProduct(int[] nums)
{
    var result = nums[0];
    for (int i = 0, p = 1, q = 1; i < nums.Length; i++)
    {
        p = (p == 0 ? 1 : p) * nums[i];
        q = (q == 0 ? 1 : q) * nums[nums.Length - 1 - i];

        result = Math.Max(result, Math.Max(p, q));
    }

    return result;

}

//int MaxProduct(int[] nums)
//{
//    int result = nums[0];

//    for (int i = 1, currMax = result, currMin = result; i < nums.Length; i++)
//    {
//        int newMax = Math.Max(Math.Max(currMin * nums[i], currMax * nums[i]), nums[i]);

//        int newMin = Math.Min(Math.Min(currMin * nums[i], currMax * nums[i]), nums[i]);

//        result = Math.Max(result, newMax);
//        currMax = newMax;
//        currMin = newMin;
//    }

//    return result;
//}

//int MaxProduct(int[] nums)
//{
//    int r = nums[0];

//    for (int i = 1, iMax = r, iMin = r; i < nums.Length; i++)
//    {
//        if (nums[i] < 0)
//        {
//            int tmp = iMax;
//            iMax = iMin;
//            iMin = tmp;
//        }

//        iMax = Math.Max(iMax * nums[i], nums[i]);
//        iMin = Math.Min(iMin * nums[i], nums[i]);

//        r = Math.Max(r, iMax);
//    }

//    return r;
//}