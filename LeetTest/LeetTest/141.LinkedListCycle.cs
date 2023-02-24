using LeetTest.Models;

ListNode n1 = new ListNode(1, new ListNode(2));
n1.next.next = n1;

ListNode n2 = new ListNode(3, new ListNode(2, new ListNode(0, new ListNode(-4))));
n2.next.next.next.next = n2.next;

HasCycle(new ListNode(1, new ListNode(2)));
HasCycle(new ListNode(1));
HasCycle(n2);
HasCycle(n1);

bool HasCycle(ListNode head)
{
    if (head == null)
        return false;

    var slow = head;
    var fast = head;

    while (fast != null && fast.next != null)
    {
        fast = fast.next.next;
        slow = slow.next;
        if (fast != null && slow.Equals(fast))
            return true;
    }

    return false;
}