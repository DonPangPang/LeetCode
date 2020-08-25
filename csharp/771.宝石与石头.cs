/*
 * @lc app=leetcode.cn id=771 lang=csharp
 *
 * [771] 宝石与石头
 */

// @lc code=start
public class Solution {
    public int NumJewelsInStones(string J, string S) {
        // char[] gems = J.ToCharArray();
        // int count = 0;
        // for(int i = 0; i < gems.Length; i++){
        //     count += Regex.Matches(S, gems[i].ToString()).Count;
        // }
        // return count;

        int count = 0;
        foreach(char gem in J.ToCharArray()){
            if(S.Contains(gem)){
                count += (S.Length-S.Replace(gem.ToString(), "").Length);
            }
        }
        return count;
    }
}
// @lc code=end

