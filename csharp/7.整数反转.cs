/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        checked
        {
            try
            {
                bool tag = false;
                if (x < 0)
                {
                    x = -x;
                    tag = true;
                }
                Queue list = new Queue();
                int result = 0;
                while (x >= 1)
                {
                    list.Enqueue(x % 10);
                    x /= 10;
                }
                if (list.Count >= 32)
                {
                    return 0;
                }
                if (tag)
                {
                    while (list.Count != 0)
                    {
                        result -= (int)list.Dequeue() * (int)Math.Pow(10, list.Count);
                    }
                }
                else
                {
                    while (list.Count != 0)
                    {
                        result += (int)list.Dequeue() * (int)Math.Pow(10, list.Count);
                    }
                }

                return result;
            }
            catch { return 0; }
        }
    }
}
// @lc code=end

