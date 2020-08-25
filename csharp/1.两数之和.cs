/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                int temp = target - nums[i];
                if (nums[j] == temp)
                {
                    return new int[2] { i, j };
                }
            }
        }

        return null;
    }
}
// @lc code=end

