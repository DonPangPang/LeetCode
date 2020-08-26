/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int beginIndex = 0;
		int endIndex = nums.Length-1;
		int midIndex = -1;

		while(beginIndex <= endIndex) {
			midIndex = (beginIndex + endIndex)/2;
			if(target < nums[midIndex]) {
				endIndex = midIndex -1;
			}else if(target > nums[midIndex]) {
				beginIndex = midIndex +1;
			}else {
				return midIndex;
			}
		}
		return beginIndex;
    } 
}
// @lc code=end

