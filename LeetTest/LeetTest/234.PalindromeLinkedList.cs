
IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1)))));
IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));

bool IsPalindrome(ListNode head)
{
    if (head == null) return false;

    ListNode middlePoint = GetFirstHalfNode(head);
    ListNode secongReversed = GetReversedListNode(middlePoint.next);
    
    while(head!=null && secongReversed !=null)
    {
        if (head.val != secongReversed.val) return false;

        head = head.next;
        secongReversed= secongReversed.next;  
    }

    //Time - O(N) Space - O(1)
    return true;
}

ListNode GetFirstHalfNode(ListNode head)
{
    ListNode fast = head;
    ListNode slow = head;

    while (fast.next != null && fast.next.next != null)
    {
        fast = fast.next.next;
        slow = slow.next;
    }
    return slow;
}

ListNode GetReversedListNode(ListNode head)
{
    ListNode prev = null;
    ListNode curr = head;
    while (curr != null)
    {
        var tmp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = tmp;
    }

    return prev;
}




class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}