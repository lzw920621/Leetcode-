﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _287_寻找重复数
{
    /*
    给定一个包含 n + 1 个整数的数组 nums，其数字都在 1 到 n 之间（包括 1 和 n），可知至少存在一个重复的整数。假设只有一个重复的整数，找出这个重复的数。

    示例 1:
    输入: [1,3,4,2,2]
    输出: 2

    示例 2:
    输入: [3,1,3,4,2]
    输出: 3

    说明：
        不能更改原数组（假设数组是只读的）。
        只能使用额外的 O(1) 的空间。
        时间复杂度小于 O(n2) 。
        数组中只有一个重复的数字，但它可能不止重复出现一次。

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/find-the-duplicate-number
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    */
    class Program
    {
        static void Main(string[] args)
        {
            int n = FindDuplicate(new int[] { 18, 13, 14, 17, 9, 19, 7, 17, 4, 6, 17, 5, 11, 10, 2, 15, 8, 12, 16, 17});
        }

        public static  int FindDuplicate(int[] nums)
        {
            for (int step = 1; step < nums.Length; step++)
            {
                for (int i = step; i < nums.Length;i++)
                {
                    if (nums[i] == nums[i - step])
                    {
                        return nums[i];
                    }
                }
            }
            return 0;            
        }

        public static int FindDuplicate1(int[] nums)//快慢指针法
        {
            // Find the intersection point of the two runners.
            int tortoise = nums[0];
            int hare = nums[0];
            do
            {
                tortoise = nums[tortoise];//走一步
                hare = nums[nums[hare]];//走两步
            } while (tortoise != hare);

            // Find the "entrance" to the cycle.
            int ptr1 = nums[0];
            int ptr2 = tortoise;
            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;            
        }
        
    }
}
