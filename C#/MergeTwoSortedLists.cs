using System;

public class ListNode {
	public int val;
	public ListNode next;
 		
	public ListNode(int val = 0, ListNode next=null) {
		this.val = val;
		this.next = next;
	}
 }

class Program
{	
    private static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode mergedListHeadNode = new ListNode();
        ListNode currentNode = mergedListHeadNode;
        
        while (list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
           else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }
        
        currentNode.next = list1 ?? list2;
        return mergedListHeadNode.next;
    }
	
static void Main()
{
	ListNode ListA = new ListNode(1, new ListNode(2, new ListNode(4)));
	ListNode ListB = new ListNode(1, new ListNode(3, new ListNode(4)));	
	ListNode currentMergedABListNode = MergeTwoLists(ListA, ListB);
	
	Console.Write("Output: [ ");
	
	while(currentMergedABListNode != null)
	{
		Console.Write($"{currentMergedABListNode.val} ");
		currentMergedABListNode = currentMergedABListNode.next;
	}
  		
  	Console.WriteLine("]");
    }
}
