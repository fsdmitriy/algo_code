using LeetTest.Models;


MergeKLists(new ListNode[] { new ListNode(1, new ListNode(4, new ListNode(5)))
    , new ListNode(1, new ListNode(3, new ListNode(4)))
    , new ListNode(2, new ListNode(6))});

// Merge with Divide And Conquer
ListNode MergeKLists(ListNode[] lists)
{
    if (lists == null)
        return null;

    while (lists.Length > 1)
    {
        var tmpList = new List<ListNode>((lists.Length-1)/2);

        for (int i = 0; i < lists.Length; i++)
        {
            var l1 = lists[i];
            var l2 = i + 1 < lists.Length ? lists[++i]: null;

            tmpList.Add(MergetTwoLists(l1, l2));
        }

        lists = tmpList.ToArray();
    }


    return lists[0];
}

//Simple merge approach
//ListNode MergeKLists(ListNode[] lists)
//{
//    ListNode result = null;

//    foreach (var list in lists)
//    {
//        result = MergetTwoLists(result, list);
//    }

//    return result;
//}

ListNode MergetTwoLists(ListNode listNode1, ListNode listNode2)
{
    ListNode dummy = new ListNode();
    ListNode curr = dummy;

    while (listNode1 != null && listNode2 != null)
    {
        if (listNode1.val <= listNode2.val)
        {
            curr.next = listNode1;
            listNode1 = listNode1.next;
        }
        else
        {
            curr.next = listNode2;
            listNode2 = listNode2.next;
        }

        curr = curr.next;
    }

    curr.next = listNode1 != null ? listNode1 : listNode2;

    return dummy.next;
}