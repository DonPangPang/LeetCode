/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = nums[0];
        int sum = 0;
        foreach (int num in nums) {
            if (sum > 0)
                sum += num;
            else
                sum = num;
            res = res > sum ? res : sum;
        }
        return res;
    }
}
// @lc code=end

