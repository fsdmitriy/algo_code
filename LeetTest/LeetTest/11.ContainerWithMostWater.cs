
MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
MaxArea(new int[] { 3, 2, 4, 2, 3, 2, 1, 2, 1, 4 });
MaxArea(new int[] { 1, 1 });

int MaxArea(int[] height)
{
    int p1 = 0, p2 = height.Length - 1, result = 0;

    while (p1 < p2)
    {
        result = Math.Max((Math.Min(height[p1], height[p2]) * (p2 - p1)), result);

        if (height[p1] > height[p2])
            p2--;
        else
            p1++;
    }

    return result;
}