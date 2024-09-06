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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        //Hashset for not to exceed the time
        HashSet<int> numsSet = new HashSet<int>(nums);
        ListNode current = head;
        ListNode prev = null;
        while(current != null){
            if(numsSet.Contains(current.val)){
               if(prev == null) head = current.next;
               else prev.next = current.next;
            }
            else prev = current;
            current = current.next;
        }
        return head;
    }
}