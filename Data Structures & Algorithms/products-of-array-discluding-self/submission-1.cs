public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1, zeroCount = 0;
        foreach (int n in nums) {
            if (n != 0) {
                totalProduct *= n;
            } else {
                zeroCount++;
            }
        }

        int[] res = new int[nums.Length];

        if (zeroCount > 1) return res;

        for (int i = 0; i < nums.Length; i++) {
            if (zeroCount > 0) {
                res[i] = (nums[i] == 0) ? totalProduct : 0;
            } else {
                res[i] = totalProduct / nums[i];
            }
        }
        return res;
    }
}
