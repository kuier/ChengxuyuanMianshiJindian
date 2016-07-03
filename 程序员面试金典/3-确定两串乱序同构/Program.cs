using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 给定两个字符串，请编写程序，确定其中一个字符串的字符重新排列后，能否变成另一个字符串。这里规定大小写为不同字符，且考虑字符串重点空格。给定一个string stringA和一个string stringB，请返回一个bool，代表两串是否重新排列后可相同。保证两串的长度都小于等于5000
 */
namespace _3_确定两串乱序同构
{
    class Program
    {
        class Same
        {
            public bool checkSam(string stringA, string stringB)
            {
                // write code here
                if (stringA.Length!=stringB.Length)
                {
                    return false;
                }
                return sort(stringA).Equals(sort(stringB));
            }

            public string sort(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                return new string(charArray);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
