/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode tmp = head;
        while(tmp != null){

            if(tmp.next == null){
                break;
            }

            if(tmp.val == tmp.next.val){
                tmp.next =  tmp.next.next;
            }else{
                tmp = tmp.next;
            }
        }
        return head;
    }
}
// @lc code=end

