﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190_颠倒二进制位
{
    /*
    颠倒给定的 32 位无符号整数的二进制位。

    示例 1：

    输入: 00000010100101000001111010011100
    输出: 00111001011110000010100101000000
    解释: 输入的二进制串 00000010100101000001111010011100 表示无符号整数 43261596，
          因此返回 964176192，其二进制表示形式为 00111001011110000010100101000000。

    示例 2：

    输入：11111111111111111111111111111101
    输出：10111111111111111111111111111111
    解释：输入的二进制串 11111111111111111111111111111101 表示无符号整数 4294967293，
          因此返回 3221225471 其二进制表示形式为 10101111110010110010011101101001。

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/reverse-bits
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    */
    class Program
    {
        static void Main(string[] args)
        {
            uint num = reverseBits(43261596);//00000010100101000001111010011100

        }

        public static uint reverseBits(uint n)
        {
            //uint num = 0;
            //uint abit;
            //int count = 32;

            //while(count>0)
            //{
            //    abit = n & 1;
            //    n = n >> 1;
            //    num = num << 1;
            //    num = num ^ abit;
            //    count--;
            //}
            //return num;

            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                result = result | (n & 1);
                n >>= 1;
            }
            return result;
        }
    }
}
