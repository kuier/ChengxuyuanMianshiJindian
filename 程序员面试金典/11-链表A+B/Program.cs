using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 有两个用链表表示的整数，每个结点包含一个数位。这些数位是反向存放的，也就是个位排在链表的首部。编写函数对这两个整数求和，并用链表形式返回结果。
给定两个链表ListNode* A，ListNode* B，请返回A+B的结果
 */
namespace _11_链表A_B
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
        class Plus
        {
            public ListNode plusAB(ListNode a, ListNode b)
            {
                // write code here
                //加数A
                int valueA = 0;
                int ValueB = 0;
                //和
                int Sum = 0;
                //进位位
                int Carry = 0;

                ListNode pNodeA = a;
                ListNode pNodeB = b;
                ListNode result = new ListNode(0);
                while (pNodeA != null  || pNodeB != null || Carry !=0)
                {
                    valueA = pNodeA == null ? 0 : pNodeA.val;
                    ValueB = pNodeB == null ? 0 : pNodeB.val;
                    Sum = (valueA + ValueB+Carry)%10;
                    Carry = (valueA + ValueB+Carry) - 10 >= 0 ? 1 : 0;
                    ListNode temp = new ListNode(Sum);
                    temp.next = result;
                    result = temp;
                    pNodeA = pNodeA == null ? null : pNodeA.next;
                    pNodeB = pNodeB == null ? null : pNodeB.next;
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(1);
            ListNode listNode2 = new ListNode(2);
            ListNode listNode3 = new ListNode(3);

            listNode1.next = listNode2;
            listNode2.next = listNode3;

            ListNode listNode4 = new ListNode(3);
            ListNode listNode5 = new ListNode(2);
            ListNode listNode6 = new ListNode(9);

            listNode4.next = listNode5;
            listNode5.next = listNode6;

            Plus plus = new Plus();
            plus.plusAB(listNode1, listNode4);

        }
    }
}
