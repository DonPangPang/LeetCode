/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除排序数组中的重复项
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        int target = nums[0];
        int count = 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != target){
                nums[count++] = target = nums[i];
            }
        }
        return count;
    }
}
// @lc code=end

