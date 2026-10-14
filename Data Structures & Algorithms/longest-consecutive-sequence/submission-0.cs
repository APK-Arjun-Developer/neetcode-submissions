public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>(nums);
        int longest = 0;
        foreach(int n in nums) {
            if(!numsSet.Contains(n - 1)) {
                int length = 1;
                while(numsSet.Contains(n + length)) {
                    length++;
                }
                longest = Math.Max(length, longest);
            }
        }
        return longest;
    }
}
