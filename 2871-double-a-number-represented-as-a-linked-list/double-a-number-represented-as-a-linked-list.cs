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
public class Solution {
    int carryover = 0;

    public ListNode DoubleIt(ListNode head) {
        if (head == null){
            return head;
        }
        var result = Recurse(head);
        var doubled = (head.val * 2) + carryover;
        head.val = doubled%10;
        if (doubled > 9) {
            var newNode = new ListNode(1, head);
            head = newNode;
        }
        
        return head;
    }

    public ListNode Recurse(ListNode head){
        if (head.next == null){
            return head;
        }

        var result = Recurse(head.next);
        Console.WriteLine($"Operating on {result.val}");
        var doubled = (result.val * 2) + carryover;
        carryover = doubled/10;
        result.val = doubled%10;

        return head;
    }
}