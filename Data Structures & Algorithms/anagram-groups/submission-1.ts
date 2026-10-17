class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs: string[]): string[][] {
        const map = new Map<string, string[]>();

        for (let s of strs) {
            const count = new Array(26).fill(0);
            for (let c of s) {
                count[c.charCodeAt(0) - 'a'.charCodeAt(0)]++;
            }
            const key = count.join(',');
            if (!map.has(key)) {
                map.set(key, []);
            }
            map.get(key).push(s);
        }

        return Array.from(map.values());
    }
}
