public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool increase = true, decrease = true;

        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] > nums[i + 1]) increase = false;
            if (nums[i] < nums[i + 1]) decrease = false;
        }

        return increase || decrease;
    }
}