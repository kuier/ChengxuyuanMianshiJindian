using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 编写代码，以给定值x为基准将链表分割成两部分，所有小于x的结点排在大于或等于x的结点之前,给定一个链表的头指针 ListNode* pHead，请返回重新排列后的链表的头指针。注意：分割以后保持原来的数据顺序不变。
 */
namespace _10_链表分割
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
        class Partition
        {
            public ListNode partition(ListNode pHead, int x)
            {
                // write code here
                ListNode beforeStart = null;
                ListNode beforeEnd = null;
                ListNode afterStart = null;
                ListNode afterEnd = null;
                while (pHead!=null)
                {
                    ListNode next = pHead.next;
                    pHead.next = null;
                    if (pHead.val <x)
                    {
                        if (beforeStart == null)
                        {
                            beforeStart = pHead;
                            beforeEnd = beforeStart;
                        }
                        else
                        {
                            beforeEnd.next = pHead;
                            beforeEnd = pHead;
                        }
                    }
                    else
                    {
                        if (afterStart == null)
                        {
                            afterStart = pHead;
                            afterEnd = afterStart;
                        }
                        else
                        {
                            afterEnd.next = pHead;
                            afterEnd = pHead;
                        }
                    }
                    pHead = next;
                }
                if (beforeStart == null)
                {
                    return afterStart;
                }
                beforeEnd.next = afterStart;
                return beforeStart;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
