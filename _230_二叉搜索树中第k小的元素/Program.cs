﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230_二叉搜索树中第k小的元素
{
    /*
    给定一个二叉搜索树，编写一个函数 kthSmallest 来查找其中第 k 个最小的元素。

    说明：
    你可以假设 k 总是有效的，1 ≤ k ≤ 二叉搜索树元素个数。

    示例 1:

    输入: root = [3,1,4,null,2], k = 1
       3
      / \
     1   4
      \
       2
    输出: 1

    示例 2:

    输入: root = [5,3,6,2,4,null,null,1], k = 3
           5
          / \
         3   6
        / \
       2   4
      /
     1
    输出: 3

    进阶：
    如果二叉搜索树经常被修改（插入/删除操作）并且你需要频繁地查找第 k 小的值，你将如何优化 kthSmallest 函数？

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/kth-smallest-element-in-a-bst
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

    */
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.left.right = new TreeNode(2);

            int num = KthSmallest(root, 1);
        }

        public static int KthSmallest(TreeNode root, int k)
        {
            int index = 0;
            int[] array = new int[1];
            InOrder(root,ref index, k,array);
            return array[0];
        }

        //中序遍历（LDR）
        public static void InOrder(TreeNode root,ref int index,int k,int[] array)
        {
            if (root == null || index==k)
            {
                return;
            }
            InOrder(root.left,ref index,k, array);//遍历左子树

            index++;
            if(index==k)
            {
                array[0] = root.val;
                return;
            }
            
            InOrder(root.right,ref index,k, array);//遍历右子树
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
