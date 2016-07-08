using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 假定我们都知道非常高效的算法来检查一个单词是否为其他字符串的子串。请将这个算法编写成一个函数，给定两个字符串s1和s2，请编写代码检查s2是否为s1旋转而成，要求只能调用一次检查子串的函数。给定两个字符串s1,s2,请返回bool值代表s2是否由s1旋转而成。字符串中字符为英文字母和空格，区分大小写，字符串长度小于等于1000。
 */
namespace _8_翻转字串
{
    class Program
    {
        class ReverseEqual
        {
            public bool checkReverseEqual(string s1, string s2)
            {
                // write code here
                s1 += s1;
                if (s1.Contains(s2))
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
