public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (var p in prices)
        {
            if (p < minPrice) minPrice = p;
            else if (p - minPrice > maxProfit) maxProfit = p - minPrice;
        }
        return maxProfit;
    }
}