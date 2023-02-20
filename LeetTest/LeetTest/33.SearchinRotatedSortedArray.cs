
Search(new int[] { 1 }, 1);
Search(new int[] { 1 }, 0);
Search(new int[] { 1, 3 }, 3);
Search(new int[] { 5, 1, 3 }, 3);
Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
Search(new int[] { 0, 1, 2, 4, 5, 6, 7 }, 0);
Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
Search(new int[] { 6, 7, 0, 1, 2, 4, 5, }, 0);
Search(new int[] { 4, 5, 6, 7, 8, 9, 0, 1, 2, 3 }, 9);

int Search(int[] nums, int target)
{
    int left = 0;
    int rigth = nums.Length - 1;

    while (left <= rigth)
    {
        int mid = (left + rigth) / 2;

        if (target == nums[mid])
            return mid;
        if (nums[left] <= nums[mid])
        {
            if (target > nums[mid] || target < nums[left])
                left = mid + 1;
            else
                rigth = mid - 1;
        }
        else
        {
            if (target < nums[mid] || target > nums[rigth])
                rigth = mid - 1;
            else
                left = mid + 1;
        }
    }

    return -1;
}