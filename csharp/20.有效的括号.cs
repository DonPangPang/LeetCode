using System;
using System.Collections;
/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 0){
            return true;
        }
        if(Array.IndexOf(new char[]{')',']','}'}, s[0]) >= 0){
            return false;
        }
        Stack map = new Stack();
        foreach(char ch in s){
            if(Array.IndexOf(new char[]{'(','[','{'}, ch) >= 0){
                map.Push(ch);
            }else{
                if(map.Count == 0){
                    return false;
                }
                if(Math.Abs(ch - (char)map.Peek()) <= 2){
                    map.Pop();
                }else{
                    return false;
                }
            }
        }

        return map.Count == 0 ? true : false;
    }
}
// @lc code=end

