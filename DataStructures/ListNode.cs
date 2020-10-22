namespace DataStructures
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode arrayConverter(int[] input)
        {
            ListNode ans = new ListNode();
            ListNode head = ans;
            foreach (var i in input)
            {
                ans.next = new ListNode(i);
                ans = ans.next;
            }

            return head.next;

        }
        // Helper
        public static ListNode arrayConverter2(int[] input)
        {
            ListNode ans = new ListNode();
            ListNode head = ans;
            foreach (var i in input)
            {
                ans.val = i;
                ans.next = new ListNode();
                ans = ans.next;
            }

            ans = null;

            //set last to null
            ListNode head2 = head;
            while (head2 != null && head2.next != null && head2.next.next != null)
            {
                head2 = head2.next;
            }

            head2.next = null;
            return head;
        }
    }

}