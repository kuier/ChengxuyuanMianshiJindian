using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 请编写一个算法，若MxN矩阵中某个元素为0，则将其所在的行与列清零。给定一个MxN的int[][]矩阵(C++中为vector>)mat和矩阵的阶数n，请返回完成操作后的int[][]矩阵(C++中为vector>)，保证n小于等于300，矩阵中的元素为int范围内。
 */
namespace _7_清除行列
{
    class Program
    {
        class Clearer
        {
            /// <summary>
            /// 不需要准确记录每个零元素的准确位置，使用两个数组分别记录零元素的所有行和列，然后第二次遍历矩阵时，若所在行或列标记为0，则将元素清零
            /// </summary>
            /// <param name="mat"></param>
            /// <param name="n"></param>
            /// <returns></returns>
            public int[][] clearZero(int[][] mat, int n)
            {
                bool[] row = new bool[mat.Length];
                bool[] column = new bool[mat[0].Length];

                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[0].Length; j++)
                    {
                        if (mat[i][j]==0)
                        {
                            row[i] = true;
                            column[j] = true;
                        }
                    }
                }

                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[0].Length; j++)
                    {
                        if (row[i] || column[j])
                        {
                            mat[i][j] = 0;
                        }
                    }
                }
                return mat;
            }
        }
        static void Main(string[] args)
        {
            int[][] mat = new int[][] {new int[] {1, 2, 3}, new int[] {4, 0, 6}, new int[] {7, 8, 9},new int[]{10,11,12}, };
            Clearer clearer = new Clearer();
            clearer.clearZero(mat, 3);
        }
    }
}
