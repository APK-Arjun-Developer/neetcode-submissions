public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for (int l = 0; l < prices.Length; l++) {
            int r = prices.Length - 1;  
            while (l < r) {
                if (prices[l] < prices[r]) {
                    maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
                }
                r--;
            }
        }
        return maxProfit;
    }
}
