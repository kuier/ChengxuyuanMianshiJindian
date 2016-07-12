using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 请编写一个函数，检查链表是否为回文。给定一个链表ListNode* pHead，请返回一个bool，代表链表是否为回文。测试样例：{1,2,3,2,1}返回：true{1,2,3,2,3}返回：false
 */
namespace _12_检查回文
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }
        class Palindrome
        {
            public bool isPalindrome(ListNode pHead)
            {
                // write code here
                ListNode fastNode = pHead;
                ListNode slowNode = pHead;
                Stack<int> stack = new Stack<int>();
                while (fastNode != null && fastNode.next != null)
                {
                    stack.Push(slowNode.val);
                    slowNode = slowNode.next;
                    fastNode = fastNode.next.next;

                }
                if (fastNode!=null)
                {
                    slowNode = slowNode.next;

                }

                while (slowNode!=null)
                {
                    int data = stack.Pop();
                    if (data!= slowNode.val)
                    {
                        return false;
                    }
                    slowNode = slowNode.next;
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
