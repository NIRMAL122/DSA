namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyLinkedList l = new MyLinkedList(10);
            //l.Append(23);
            //l.Append(12);
            //l.Append(76);
            //l.Insert(2, 25);
            //l.Remove(34);
            //l.PrintLinkedList();
            //l.Reverse();
            //l.PrintLinkedList();



            //MyDoublyLinkedList dl = new MyDoublyLinkedList(10);
            //dl.Append(20);
            //dl.Append(30);
            //dl.Append(40);
            //dl.Prepend(6);
            //dl.Prepend(4);
            //dl.Prepend(2);
            //dl.Insert(3, 8);
            //dl.Insert(4, 10);
            //dl.Remove(5);
            //dl.PrintDLinkedList();



            // Create a palindrome linked list: 1 -> 2 -> 3 -> 2 -> 1
            //ListNode head = new ListNode(1);
            //head.Next = new ListNode(2);
            //head.Next.Next = new ListNode(3);
            //head.Next.Next.Next = new ListNode(1);
            //head.Next.Next.Next.Next = new ListNode(1);

            //bool isPalindrome = Palindrome.IsPalindrome(head);
            //bool isPalindrome = Palindrome.IsPalindromeOrg(head);

            //if (isPalindrome)
            //    Console.WriteLine("The linked list is a palindrome.");
            //else
            //    Console.WriteLine("The linked list is not a palindrome.");


            AddTwoNumber obj= new AddTwoNumber();

            NumberNode value1= new NumberNode(1);
            value1.next= new NumberNode(4);
            value1.next.next= new NumberNode(3);

            NumberNode value2= new NumberNode(5);
            value2.next= new NumberNode(6);
            value2.next.next= new NumberNode(4);

            obj.AddTwoNumbersEff(value1, value2);
            obj.AddTwoNumbers(value1, value2);
            //obj.test();


        }
    }
}