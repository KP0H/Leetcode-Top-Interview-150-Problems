/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var tail = dummy;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int a = l1?.val ?? 0;
            int b = l2?.val ?? 0;
            int sum = a + b + carry;
            carry = sum / 10;

            tail.next = new ListNode(sum % 10);
            tail = tail.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return dummy.next;
    }
}