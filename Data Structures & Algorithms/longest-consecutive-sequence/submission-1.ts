class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums: number[]): number {
        const set = new Set(nums);
        let max = 0;
        for (const n of nums) {
            if (!set.has(n - 1)) {
                let length = 1;
                while (set.has(n + length)) {
                    length++;
                }
                max = Math.max(max, length);
            }
        }
        return max;
    }
}
