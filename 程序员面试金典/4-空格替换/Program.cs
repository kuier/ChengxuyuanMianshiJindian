using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 请编写一个方法，将字符串中的空格全部替换为“%20”。假定该字符串有足够的空间存放新增的字符，并且知道字符串的真实长度(小于等于1000)，同时保证字符串由大小写的英文字母组成。给定一个string iniString 为原始的串，以及串的长度 int len, 返回替换后的string。
 */
namespace _4_空格替换
{
    class Program
    {
        class Replacement
        {
            public string replaceSpace(string iniString, int length)
            {
                // write code here
                if (iniString == "" || length <=0)
                {
                    return "";
                }
                char[] array = iniString.ToCharArray();
                //空格数量
                int spaceCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == ' ')
                    {
                        spaceCount ++;
                    }
                }
                int resultLength = array.Length + 2*spaceCount;
                char[] result = new char[resultLength];
                //两个指针分别指向两个数组的末尾
                for (int i = array.Length-1,j=resultLength-1; i >= 0; i--)
                {
                    if (array[i] == ' ')
                    {
                        result[j--] = '0';
                        result[j--] = '2';
                        result[j--] = '%';
                    }
                    else
                    {
                        result[j--] = array[i];
                    }
                }
                return new string(result);
            }
        }
        static void Main(string[] args)
        {
            Replacement r = new Replacement();
            Console.WriteLine(r.replaceSpace("Hello  world", 12));
            Console.ReadLine();
        }
    }
}
