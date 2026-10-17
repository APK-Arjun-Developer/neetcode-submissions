class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums: number[]): number[] {
        let totalProduct = 1;
        let zeroCount = 0;
        for (const n of nums) {
            if (n !== 0) {
                totalProduct *= n;
            } else {
                zeroCount++;
            }
        }

        const res = new Array<number>(nums.length).fill(0);
        if (zeroCount > 1) {
            return res;
        }
        for (let i = 0; i < nums.length; i++) {
            if (zeroCount > 0) {
                res[i] = nums[i] === 0 ? totalProduct : 0;
            } else {
                res[i] = totalProduct / nums[i];
            }
        }

        return res;
    }
}
