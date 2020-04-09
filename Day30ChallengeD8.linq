<Query Kind="Program" />

//Day 8
//Middle of the Linked List.
//Given a non-empty, singly linked list with head node head, return a middle node of linked list.
//If there are two middle nodes, return the second middle node.
void Main()
{
	var head = new ListNode(1);
	head.next = new ListNode(2);
	head.next.next = new ListNode(3);
	head.next.next.next = new ListNode(4);
	head.next.next.next.next = new ListNode(5);
	head.next.next.next.next.next = new ListNode(6);
	
	var middle = FindMiddle1(head);
	middle.Dump();
}

public ListNode FindMiddle1(ListNode head) // Better solution, 2 pointer approach.
{
	if(head == null || head.next == null) return head;
	
	ListNode slow = head;
	ListNode fast = head;
	
	while(fast != null && fast.next != null)
	{
		slow = slow.next;
		fast = fast.next.next;
	}
	
	return slow;
}

public ListNode FindMiddle(ListNode head) // initial solution
{
	var temp = new ListNode(0);
	
	temp = head;
	int l = 0;

	//find the length of list
	while(temp != null)
	{
		l++;
		temp = temp.next;
	}
	
	int mid = l/2;
	mid.Dump();
	temp = head;
	int i =0;
	while(i <= mid)
	{
		if(i==mid) return temp;	
		
		temp = temp.next;
		i++;
	}
	
	return null;
}



public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }