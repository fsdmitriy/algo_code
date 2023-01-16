int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

var result = Trap(height);

int Trap(int[] height)
{
    if (height.Length == 0)
        return 0;

    int leftPoint = 0, rigthPoint = height.Length - 1;
    int maxLeft = 0, maxRigth = 0, totalSum = 0;

    while (leftPoint < rigthPoint)
    {
        if (height[leftPoint] < height[rigthPoint])
        {
            if (height[leftPoint] >= maxLeft)
            {
                maxLeft = height[leftPoint];
            }
            else
            {
                totalSum += maxLeft - height[leftPoint];
            }

            leftPoint++;
        }
        else
        {
            if (height[rigthPoint] > maxRigth)
            {
                maxRigth = height[rigthPoint];
            }
            else
            {
                totalSum += maxRigth - height[rigthPoint];
            }

            rigthPoint--;
        }
    }


    return totalSum;
}