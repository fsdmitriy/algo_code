
FindMin(new int[] { 3, 1, 2 });
FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 });
FindMin(new int[] { 3, 4, 5, 1, 2 });
FindMin(new int[] { 11, 13, 15, 17 });

int FindMin(int[] nums)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        if (nums[left] <= nums[right])
            return nums[left];

        int mid = (left + right) / 2;

        if (nums[mid] >= nums[right])
            left = mid + 1;
        else
            right = mid;
    }

    return 0;
}