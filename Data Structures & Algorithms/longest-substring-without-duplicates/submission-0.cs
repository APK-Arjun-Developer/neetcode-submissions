public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new();
        int res = 0;
        int l = 0;
        for (int r = 0; r < s.Length; r++) {
            if (map.ContainsKey(s[r])) {
                l = Math.Max(map[s[r]] + 1, l);
            }
            map[s[r]] = r;
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
