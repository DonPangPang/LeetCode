/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        int len = 0;
        s = s.Trim();
        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] != ' '){
                len++;
            }

            if(s[i] == ' ' && i != s.Length -1){
                break;
            }
        }
        return len;
    }
}
// @lc code=end

