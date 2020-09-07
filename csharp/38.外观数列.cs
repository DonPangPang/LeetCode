using System.Reflection.Metadata;
/*
 * @lc app=leetcode.cn id=38 lang=csharp
 *
 * [38] 外观数列
 */

// @lc code=start
public class Solution {
    public string CountAndSay(int n) {
        string result = "";
        string temp = "";

        for(int i = 1; i <= n; i++){
            if(i == 1){
                temp = "1";
            }
            result = temp;
            temp = "";
            int flag = 0;
            int cursor = 0;
            while(cursor <= result.Length){
                if(cursor == result.Length || result[cursor] != result[flag]){
                    temp += (cursor-flag).ToString()+result[flag];
                    flag = cursor;
                }
                cursor++;
            }
        }

        return result;
    }
}
// @lc code=end

