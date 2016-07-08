using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 利用字符重复出现的次数，编写一个方法，实现基本的字符串压缩功能。比如，字符串“aabcccccaaa”经压缩会变成“a2b1c5a3”。若压缩后的字符串没有变短，则返回原先的字符串。给定一个string iniString为待压缩的串(长度小于等于3000)，保证串内字符均由大小写英文字母组成，返回一个string，为所求的压缩后或未变化的串。
 */
namespace _5_基本字符串压缩
{
    class Program
    {
        class Zipper
        {
            public string zipString(string iniString)
            {
                // write code here
                StringBuilder sb = new StringBuilder();
                char[] array = iniString.ToCharArray();
                //两个指针，相减就是重复的次数
                int pHead = 0;
                int pEnd = 1;
                int count = 1;
                for (; pEnd < array.Length; pEnd++)
                {
                    if (array[pEnd] == array[pHead] )
                    {
                        count++;
                    }
                    else
                    {
                        sb.Append(array[pHead]);
                        sb.Append(count);
                        pHead = pEnd;
                        count = 1;
                    }
                    //终止
                    if (pEnd == array.Length - 1)
                    {
                        sb.Append(array[pHead]);
                        sb.Append(count);
                        break;
                    }
                }
                if (sb.ToString().Length >iniString.Length)
                {
                    return iniString;
                }
                return sb.ToString();
            }
        }
        static void Main(string[] args)
        {
            Zipper zipper = new Zipper();
            Console.WriteLine(zipper.zipString("aabcccaaadfffff"));
            Console.WriteLine();
        }
    }
}
