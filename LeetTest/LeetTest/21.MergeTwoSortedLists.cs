﻿
MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
MergeTwoLists(new ListNode(), new ListNode());
MergeTwoLists(new ListNode(), new ListNode(0));

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null) return list2;
    if (list2 == null) return list1;

    ListNode dummy = new ListNode(0); // add dummy node to handle first comparation
    ListNode curr = dummy;

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            curr.next = list1;
            list1 = list1.next;
        }
        else
        {
            curr.next = list2;
            list2 = list2.next;
        }

        curr = curr.next;
    }

    curr.next = list1 != null ? list1 : list2;

    return dummy.next;
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