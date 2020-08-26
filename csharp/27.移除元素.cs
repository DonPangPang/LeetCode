/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0){
            return 0;
        }
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[count++] = nums[i];
            }
        }
        return count;
    }
}
// @lc code=end

