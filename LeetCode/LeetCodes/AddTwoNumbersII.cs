using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
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
     }
    public class AddTwoNumbersII
    {
        public void AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int a = 0;
            int b = 0;

            ListNode current1= l1;
            ListNode current2= l2;

            while (current1 != null)
            {
                a = a * 10 + current1.val;
                current1 = current1.next;
            }

            while(current2 != null)
            {
                b= b * 10 + current2.val;
                current2= current2.next;
            }

            Console.WriteLine("a="+a+" b="+b);
            int sum= a+b;
            Console.WriteLine("sum="+sum);
            ListNode head = null;
            

            if (sum == 0)
            {
                Console.WriteLine("zero");
                //return new ListNode(0);
            }


            while(sum > 0)
            {
                int digit = sum % 10;
                sum = sum / 10;

                ListNode newNode = new ListNode(digit);
                newNode.next = head;
                head = newNode;

            }

            ListNode abc = head;
            while(abc != null)
            {
                Console.Write("->" + abc.val);
                abc = abc.next;
            }
        }

        public void AddTwoNumbersEff(ListNode l1, ListNode l2)
        {
            l1 = ReverseLinkedList(l1);
            l2 = ReverseLinkedList(l2);

            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10;
                sum = sum % 10;

                current.next = new ListNode(sum);
                current = current.next;
            }

            ListNode result= ReverseLinkedList(dummy.next);

            while(result != null)
            {
                Console.Write("->"+result.val);
                result=result.next;
            }
        }

        public static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
    
}
