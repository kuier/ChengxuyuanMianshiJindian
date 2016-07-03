using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 请实现一个算法，在不使用额外数据结构和储存空间的情况下，翻转一个给定的字符串(可以使用单个过程变量)。给定一个string iniString，请返回一个string，为翻转后的字符串。保证字符串的长度小于等于5000。
 */
namespace _2_原串翻转
{
    class Program
    {
        class Reverse
        {
            public string reverseString(string iniString)
            {
                // write code here
                char[] oriArray = iniString.ToCharArray();
                int j = iniString.Length;
                for (int i = 0; i < j; i++)
                {
                    char temp = oriArray[j - 1];
                    oriArray[j - 1] = oriArray[i];
                    oriArray[i] = temp;
                    j--;
                }
                return new string(oriArray);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
