# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        first_sum = ""
        second_sum = ""
        while l1 is not None:
            first_sum = first_sum + str(l1.val)
            l1 = l1.next
        while l2 is not None:
            second_sum = second_sum + str(l2.val)
            l2 = l2.next
        result_string = str(int(first_sum[::-1]) + int(second_sum[::-1]))[::-1]

        head_node = None
        prev_node = None

        for index in range(0, len(result_string)):
            element = result_string[index]
            node = ListNode(val=element, next=None)

            if prev_node is not None:
                prev_node.next = node
            prev_node = node
            if head_node is None:
                head_node = node
        return head_node