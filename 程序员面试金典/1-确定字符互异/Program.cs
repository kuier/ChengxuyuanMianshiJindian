using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 请实现一个算法，确定一个字符串的所有字符是否全都不同。这里我们要求不允许使用额外的存储结构。给定一个string iniString，请返回一个bool值,True代表所有字符全都不同，False代表存在相同的字符。保证字符串中的字符为ASCII字符。字符串的长度小于等于3000。
 */
namespace _1_确定字符互异
{
    class Program
    {
        class Different
        {
            public bool checkDifferent(string iniString)
            {
                // write code here
                if (iniString.Length>256)
                {
                    return false;
                }
                bool[] charSetBools = new bool[256];
                for (int i = 0; i < iniString.Length; i++)
                {
                    int val = iniString[i];
                    if (charSetBools[val])
                    {
                        return false;
                    }
                    charSetBools[val] = true;
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
