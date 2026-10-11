public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> smap = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (smap.ContainsKey(s[i])) {
                smap[s[i]] += 1;
            } else {
                smap[s[i]] = 1;
            }
        }

        foreach (char c in t) {
            if (!smap.ContainsKey(c)) {
                return false;
            }

            smap[c]--;

            if (smap[c] < 0) {
                return false;
            }
        }

        return true;
    }
}
