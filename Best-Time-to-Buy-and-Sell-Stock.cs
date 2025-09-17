public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 1)
            return 0;
        int maxProfit = int.MinValue;
        int cheap = prices[0];
        for(int i = 1; i<prices.Length; i++)
        {
            if (prices[i] < cheap)
                cheap = prices[i];
            if ((prices[i] - cheap) > maxProfit)
                maxProfit = prices[i] - cheap;
        }
        return maxProfit;
    }
}
