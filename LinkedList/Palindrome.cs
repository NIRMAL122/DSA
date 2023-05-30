using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int value)
        {
            Value = value;
        }
    }
    public class Palindrome
    {

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.Next == null)
                return true;

            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;

            // Find the middle node using slow and fast pointers
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;

                ListNode next = slow.Next;
                slow.Next = prev;
                prev = slow;
                slow = next;
            }

            // If the length is odd, skip the middle node
            if (fast != null)
                slow = slow.Next;

            // Compare the reversed second half with the first half
            while (prev != null && slow != null)
            {
                if (prev.Value != slow.Value)
                    return false;

                prev = prev.Next;
                slow = slow.Next;
            }

            return true;
        }

        public static bool IsPalindromeOrg(ListNode head)
        {
            ListNode org = head;

            ListNode a = null;
            ListNode b = head;

            while (b != null)
            {
                ListNode c = b.Next;
                b.Next = a;
                a = b;
                b = c;
            }
            head = a;

            
            while (org != null)
            {
                Console.WriteLine(org.Value);
                org= org.Next;

            }

            while (org != null && head != null)
            {
                if (org.Value != head.Value)
                {
                    return false;
                }


                org = org.Next;
                head = head.Next;
            }

            return true;
        }
    }
}
