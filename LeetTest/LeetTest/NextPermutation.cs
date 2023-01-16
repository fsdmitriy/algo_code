
//var arr = new int[] { 1, 2, 3 };
//var arr = new int[] { 1, 3, 2 };
//var arr = new int[] { 6, 2, 1, 5, 4, 3, 0 };
var arr = new int[] { 3, 2, 1 };

NextPermutation(arr);

void NextPermutation(int[] nums)
{
    int i = arr.Length - 2;
    while (i >= 0 && arr[i] >= arr[i + 1]) i--;

    if (i >= 0)
    {
        int j = arr.Length - 1;
        while (arr[i] >= arr[j]) j--;
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    var span = arr.AsSpan(i + 1, arr.Length - i - 1);

    arr.AsSpan(i + 1, arr.Length - i - 1).Reverse();

    //int left = nums.Length - 2;
    //int rigth = nums.Length - 1;

    //while (left >= 0 && nums[left] >= nums[left + 1]) left--;

    //if (left < 0)
    //{
    //    Reverse(nums, 0, rigth);
    //    return;
    //}

    //while (nums[left] >= nums[rigth]) rigth--;

    //Swap(nums, left, rigth);
    //Reverse(nums, left+1, nums.Length - 1);
}

void Swap(int[] nums, int i, int j)
{
    (nums[i], nums[j]) = (nums[j], nums[i]);
}

void Reverse(int[] nums, int l, int r)
{
    while (l < r)
    {
        Swap(nums, l, r);
        l++;
        r--;
    }
}
