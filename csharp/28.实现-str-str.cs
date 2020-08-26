/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 实现 strStr()
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        // 超级偷懒写法
        // return haystack.IndexOf(needle);

        // 花里胡哨的写法
        // if(needle.Length == 0){
        //     return 0;
        // }
        // string[] temp = haystack.Split(needle);
        // if(temp.Length > 1){
        //     return temp[0].Length;
        // }
        // return -1;

        // 没啥技术含量的写法
        if(needle.Length == 0){
            return 0;
        };

        for(int i = 0; i < haystack.Length; i++){
            if(haystack.Length - i < needle.Length){
                return -1;
            }

            int count = 0;
            for(int j = 0; j < needle.Length; j++){
                if(haystack[i+j] != needle[j]){
                    break;
                }
                ++count;
                //Console.WriteLine($"{haystack[i+j]}:{needle[j]}:Count:{i-count}");
                if(count == needle.Length){
                    return (i+j+1)-count;
                }
            }
        }
        return -1;

        // 脑袋进水的写法
        // if(needle.Length == 0){
        //     return 0;
        // }
        // int hayCount = 0;
        // int neeCount = 0;
        // int count = 0;
        // int target = 0;
        // while(hayCount < haystack.Length){
        //     Console.WriteLine(hayCount+":"+neeCount);
        //     if(haystack[hayCount] == needle[neeCount]){
        //         hayCount++;
        //         neeCount++;
        //         count++;
        //     }else{
        //         hayCount++;
        //         count = 0;
        //         neeCount = 0;
        //         target++;
        //         hayCount = target;
        //     }

        //     if(count == needle.Length){
        //         return hayCount-count;
        //     }
        // }
        // return -1;
    }
}
// @lc code=end

