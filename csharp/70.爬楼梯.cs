/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2){
            return n;
        }
        int tmp1 = 1;
        int tmp2 = 2;
        for(int i = 3; i <= n; i++){
            int tmp = tmp1+tmp2;
            tmp1 = tmp2;
            tmp2 = tmp;
        }
        return tmp2;
    }
}
// @lc code=end

