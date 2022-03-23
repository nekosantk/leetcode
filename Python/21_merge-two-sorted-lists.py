# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        headnode = None
        curnode = None
        if list1 is None:
            return list2
        if list2 is None:
            return list1

        curnode_1 = list1
        curnode_2 = list2

        while True:
            if curnode_1.val < curnode_2.val:
                if headnode is None:
                    headnode = ListNode(val=curnode_1.val)
                    curnode = headnode
                else:
                    curnode.next = ListNode(val=curnode_1.val)
                    curnode = curnode.next
                if curnode_1.next is None:
                    curnode.next = curnode_2
                    return headnode
                curnode_1 = curnode_1.next
            else:
                if headnode is None:
                    headnode = ListNode(val=curnode_2.val)
                    curnode = headnode
                else:
                    curnode.next = ListNode(val=curnode_2.val)
                    curnode = curnode.next
                if curnode_2.next is None:
                    curnode.next = curnode_1
                    return headnode
                curnode_2 = curnode_2.next