using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class NumberNode
    {
      public int val;
      public NumberNode next;
      public NumberNode(int val = 0, NumberNode next = null)
      {
         this.val = val;
         this.next = next;
      }
    }
    public class AddTwoNumber
    {
        public void AddTwoNumbers(NumberNode l1, NumberNode l2)
        {
            int first = 0;
            int second = 0;
            NumberNode current1 = l1;
            NumberNode current2 = l2;
            while (current1 != null)
            {
                first = first * 10 + current1.val;
                current1 = current1.next;
            }
            while (current2 != null)
            {
                second = second * 10 + current2.val;
                current2 = current2.next;
            }

            int third = reverseNumber(first) + reverseNumber(second);
            Console.WriteLine(third);

            int value3 = third;
            NumberNode head = null;
            NumberNode previous = null;

            if (value3 == 0)
            {
                ListNode zero = new ListNode(0);
                Console.WriteLine("zero");
                return;
            }


            while (value3 != 0)
            {
                int z = value3 % 10;
                NumberNode l3 = new NumberNode(z);
                if (head == null)
                {
                    head = l3;
                }
                else
                {
                    previous.next = l3;
                }
                previous = l3;
                value3 = value3 / 10;

            }

            NumberNode current3 = head;
            while (current3 != null)
            {
                Console.Write("->" + current3.val);
                current3 = current3.next;
                //Console.WriteLine();
            }
        }

        
        public void AddTwoNumbersEff(NumberNode l1, NumberNode l2)
        {
            NumberNode l3 = new NumberNode(0);
            NumberNode current = l3;
            int carry = 0;

            while(l1!=null || l2!=null)
            {
                int x= l1!=null? l1.val : 0;
                int y= l2!=null? l2.val : 0;
                int sum= x+ y + carry;
                Console.WriteLine("sum="+ sum);
                carry = sum / 10;
                Console.WriteLine("carry="+carry);

                current.next = new NumberNode(sum % 10);
                current= current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (carry > 0)
            {
                current.next= new NumberNode(carry);
            }
            

        }
        public void test()
        {
            long b = reverseNumber(1999999999);
            Console.WriteLine(b);
        }

        private int reverseNumber(int num)
        {
            int a = 0;
            while(num > 0)
            {
                a = a*10+ num % 10;
                num = num / 10;
            }
            return a;
        }
    }
}
