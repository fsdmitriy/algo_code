using LeetTest.Models;

RemoveNthFromEnd(new ListNode(1), 1);
RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
RemoveNthFromEnd(new ListNode(1, new ListNode(2)), 1);

//implemented using two points
ListNode RemoveNthFromEnd(ListNode head, int n)
{
    ListNode dummyNode = new ListNode(0, head);        
    var left = dummyNode;
    var right = head;
    while (n> 0)
    {
        right = right.next;
        n--;
    }

    while (right != null)
    {
        left = left.next;
        right = right.next;
    }

    left.next = left.next.next;

    return dummyNode.next;
}


// implemented using indexer
//ListNode RemoveNthFromEnd(ListNode head, int n)
//{
//    int indx = 0;
//    ListNode curr = head;
//    while (curr != null)
//    {
//        curr = curr.next;
//        indx++;
//    }

//    for (int i = 1; i < n; i++)
//    {
//        indx--;
//    }

//    ListNode dummyNode = new ListNode();
//    dummyNode.next = head;
//    curr = dummyNode;
//    int currIndx = 1;
//    while (curr != null)
//    {
//        if (currIndx == indx)
//        {
//            curr.next = curr.next.next;
//            break;
//        }
//        curr = curr.next;
//        currIndx++;
//    }

//    return dummyNode.next;
//}