public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minBuy = prices[0];

        foreach (int sell in prices) {
            maxProfit = Math.Max(maxProfit, sell - minBuy);
            minBuy = Math.Min(minBuy, sell);
        }

        return maxProfit;

        // int maxProfit = 0;
        // for (int l = 0; l < prices.Length; l++) {
        //     int r = prices.Length - 1;  
        //     while (l < r) {
        //         if (prices[l] < prices[r]) {
        //             maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
        //         }
        //         r--;
        //     }
        // }
        // return maxProfit;
    }
}
