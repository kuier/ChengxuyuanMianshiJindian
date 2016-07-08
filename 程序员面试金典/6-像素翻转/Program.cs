using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 有一副由NxN矩阵表示的图像，这里每个像素用一个int表示，请编写一个算法，在不占用额外内存空间的情况下(即不使用缓存矩阵)，将图像顺时针旋转90度。给定一个NxN的矩阵，和矩阵的阶数N,请返回旋转后的NxN矩阵,保证N小于等于500，图像元素小于等于256。
 */
namespace _6_像素翻转
{
    class Program
    {
        class Transform
        {
            public int[][] transformImage(int[][] mat, int n)
            {
                // write code here
                //为n*n的矩阵，简单了
                for (int i = 0; i < n/2; i++)
                {
                    int first = i;
                    int last = n - 1 - first;
                    for (int j = first; j < last; j++)
                    {
                        int offerset = j - first;
                        int top = mat[first][j];

                        //左到上
                        mat[first][j] = mat[last - offerset][first];
                        //下到左
                        mat[last - offerset][first] = mat[last][last - offerset];
                        //右到下
                        mat[last][last - offerset] = mat[j][last];
                        //上到右
                        mat[j][last] = top;
                    }
                }
                return mat;
            }
        }
        static void Main(string[] args)
        {
            int[][] mat = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9},
            };
            Transform transform = new Transform();
            transform.transformImage(mat, 3);
        }
    }
}
