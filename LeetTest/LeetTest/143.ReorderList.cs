using LeetTest.Models;

ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));

void ReorderList(ListNode head)
{
    var middle = GetMiddle(head);
    var reversed = Reverse(middle.next);
    middle.next = null;

    var curr = head;
    while (reversed != null)
    {
        var tmpC = curr.next;
        var tmpR = reversed.next;
        curr.next = reversed;
        reversed.next = tmpC;

        curr = tmpC;
        reversed = tmpR;
    }
}

ListNode GetMiddle(ListNode head)
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

ListNode Reverse(ListNode head)
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