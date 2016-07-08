using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 实现一个算法，删除单向链表中间的某个结点，假定你只能访问该结点。给定带删除的节点，请执行删除操作，若该节点为尾节点，返回false，否则返回true
 */
namespace _9_访问单个节点的删除
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

        private class Remove
        {
            public bool removeNode(ListNode pNode)
            {
                // write code here
                if (pNode.next == null || pNode == null)
                {
                    return false;
                }
                ListNode temp = pNode.next;
                pNode = pNode.next;
                pNode.val = temp.val;
                pNode.next = temp.next;
                return true;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
