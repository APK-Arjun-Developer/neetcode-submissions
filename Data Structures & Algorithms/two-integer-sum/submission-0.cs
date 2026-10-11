public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int completion = target - nums[i];
            if (seen.ContainsKey(completion)) {
                return new int[] { seen[completion], i };
            }
            seen.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
