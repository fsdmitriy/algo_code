
PairSum(new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1)))));
PairSum(new ListNode(4, new ListNode(2, new ListNode(2, new ListNode(3)))));


int PairSum(ListNode head)
{
    var middlePoint = GetMiddlePoint(head);
    var reversedSecondHalf = ReverseNode(middlePoint.next);

    int result = 0;

    while (reversedSecondHalf != null)
    {
        result = Math.Max((head.val + reversedSecondHalf.val), result);
        reversedSecondHalf = reversedSecondHalf.next;
        head = head.next;
    }

    return result;
}
ListNode GetMiddlePoint(ListNode head)
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

ListNode ReverseNode(ListNode head)
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