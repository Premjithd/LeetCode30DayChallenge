//Given a linked list, rotate the list to the right by k places, where k is non-negative.
//Input: 1->2->3->4->5->NULL, k = 2
//Output: 4->5->1->2->3->NULL
//Explanation:
//rotate 1 steps to the right: 5->1->2->3->4->NULL
//rotate 2 steps to the right: 4->5->1->2->3->NULL

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {

        if(head == null || head.next == null || k == 0) return head;
        
        var tail = head;
        int L = 1;  // Get the length of linked list.
        while(tail.next != null){
            L++;
            tail = tail.next;
        }
        
        tail.next = head;   // connect tail to head to make it circular.
        
        k %= L;
        
        int breakpoint = L - k;
        
        tail = head;
        
        int i=1;
        while(i< breakpoint){   // traverse until the breakpoint.
            tail = tail.next;
            i++;
        }
        
        head = tail.next;  // set new head.
        tail.next = null;  // Break at the breakpoint.
        
        
        return head;
    }
}