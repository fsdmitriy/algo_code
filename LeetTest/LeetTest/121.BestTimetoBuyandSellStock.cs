
MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
MaxProfit(new int[] { 7, 6, 4, 3, 1 });

int MaxProfit(int[] prices)
{
    int minPrice = prices[0], result = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        minPrice = Math.Min(minPrice, prices[i]);
        result = Math.Max(result, prices[i] - minPrice);
    }

    return result;
}