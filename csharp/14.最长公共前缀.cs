/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string head = "";
        if(strs.Length == 0){
            return head;
        }
        int len = strs[0].Length;
        foreach(var str in strs){
            if(str.Length < len){
                len = str.Length;
            }
        }

        for(int i = 0; i < len; i++){
            int temp = 0;
            foreach(var str in strs){
                if(str[i] == strs[0][i]){
                    temp++;
                }else{
                    return head;
                }

                if(temp == strs.Length){
                    head+=str[i];
                }
            }
        }

        return head;
    }
}
// @lc code=end

