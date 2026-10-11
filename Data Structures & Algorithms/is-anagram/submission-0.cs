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

        Dictionary<char, int> tmap = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++) {
            if (tmap.ContainsKey(t[i])) {
                tmap[t[i]] += 1;
            } else {
                tmap[t[i]] = 1;
            }
        }

        foreach (var (key, value) in smap) {
            tmap.TryGetValue(key, out int tmapValue);
            if (value == tmapValue) {
                continue;
            }  else {
                return false;
            }
        }
        return true;
    }
}
