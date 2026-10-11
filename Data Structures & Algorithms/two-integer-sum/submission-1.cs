public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int completion = target - nums[i];
            if (map.ContainsKey(completion)) {
                return new int[] { map[completion], i };
            }
            map.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
