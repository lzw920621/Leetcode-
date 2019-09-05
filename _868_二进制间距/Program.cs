﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _868_二进制间距
{
    /*
    给定一个正整数 N，找到并返回 N 的二进制表示中两个连续的 1 之间的最长距离。 
    如果没有两个连续的 1，返回 0 。
 
    示例 1：

    输入：22
    输出：2
    解释：
    22 的二进制是 0b10110 。
    在 22 的二进制表示中，有三个 1，组成两对连续的 1 。
    第一对连续的 1 中，两个 1 之间的距离为 2 。
    第二对连续的 1 中，两个 1 之间的距离为 1 。
    答案取两个距离之中最大的，也就是 2 。

    示例 2：

    输入：5
    输出：2
    解释：
    5 的二进制是 0b101 。

    示例 3：

    输入：6
    输出：1
    解释：
    6 的二进制是 0b110 。

    示例 4：

    输入：8
    输出：0
    解释：
    8 的二进制是 0b1000 。
    在 8 的二进制表示中没有连续的 1，所以返回 0 。

    提示：

        1 <= N <= 10^9

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/binary-gap
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

    */
    class Program
    {
        static void Main(string[] args)
        {
            int max = BinaryGap2(22);
        }

        //方法1 转化为字符串处理
        public static int BinaryGap(int N)
        {
            if (N == 0|| (N&(N-1))==0) return 0;

            string str = Convert.ToString(N, 2);

            int max = 0;
            int left = 0;
            
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    max = Math.Max(max, i - left);
                    left = i;
                }
            }
            return max;
        }

        //
        public static int BinaryGap2(int N)
        {
            int[] A = new int[32];
            int t = 0;
            for (int i = 0; i < 32; i++)
            {
                if (((N >> i) & 1) != 0)
                {
                    A[t] = i;
                    t++;
                }                    
            }
                           
            int ans = 0;
            for (int i = 0; i < t - 1; ++i)
                ans = Math.Max(ans, A[i + 1] - A[i]);
            return ans;
        }

    }
}
