/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        var str = x.ToString().ToCharArray();
        Array.Reverse(str);

        var res = string.Join("", str);

        return x.ToString().Equals(res);
    }
}
// @lc code=end

