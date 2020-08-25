/*
 * @lc app=leetcode.cn id=1108 lang=csharp
 *
 * [1108] IP 地址无效化
 */

// @lc code=start
public class Solution {
    public string DefangIPaddr(string address) {
        return address.Replace(".", "[.]");
    }
}
// @lc code=end

