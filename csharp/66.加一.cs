/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length-1; i >= 0; i--){
            if(digits[i] != 9){
                digits[i] = digits[i]+1;
                return digits;
            }

            digits[i] = 0;
        }

        int[] newDigits = new int[digits.Length+1];
        newDigits[0] = 1;
        return newDigits;
    }
}
// @lc code=end

