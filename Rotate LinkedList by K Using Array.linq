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
        
        if(head == null || head.next == null || k ==0) return head;
        
        int L = 1;
        var temp = head;
        
        while(temp.next != null){
            L++;
            temp = temp.next;
        }

        
        int[] A = new int[L];
        
        var temp1 = head;
        A[0] = temp1.val;
        
        int i=1;
        while(temp1.next != null){
            A[i] = temp1.next.val;
            i++;
            temp1 = temp1.next;
        }
        
        k %= L;
        
        rotateA(A,0,L-1);
        rotateA(A,0,k-1);
        rotateA(A,k,L-1);
        
        
        var result = new ListNode(A[0]);
        var result1 = result;
        
        i=1;
        while(i<L){
            result.next = new ListNode(0);
            result = result.next;
            
            result.val = A[i];
            i++;
        }
        
        
        return result1;
    }
    
    
    public void rotateA(int[] A, int s, int e){
        
        if(A.Length == 0) return;
        
        for(int m=s,n=e;m<n;m++,n--){
            int temp = A[m];
            A[m] = A[n];
            A[n] = temp;
        }
        
    }
}