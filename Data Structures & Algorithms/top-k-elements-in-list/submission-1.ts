class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums: number[], k: number): number[] {
        const count = new Map<number, number>();
        const freq = Array.from({ length: nums.length + 1 }, () => new Array<number>());

        for (const c of nums) {
            count[c] = (count[c] || 0) + 1;
        }
        for (const n in count) {
            freq[count[n]].push(parseInt(n));
        }

        const res: number[] = [];
        for (let i = freq.length - 1; i >= 0; i--) {
            for (const n of freq[i]) {
                res.push(n);
                if (res.length === k) {
                    return res;
                }
            }
        }

        return res;
    }
}
