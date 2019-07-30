﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _669_修剪二叉搜索树
{
    /*
    给定一个二叉搜索树，同时给定最小边界L 和最大边界 R。通过修剪二叉搜索树，使得所有节点的值在[L, R]中 (R>=L) 。
    你可能需要改变树的根节点，所以结果应当返回修剪好的二叉搜索树的新的根节点。

    示例 1:

    输入: 
        1
       / \
      0   2

      L = 1
      R = 2

    输出: 
        1
          \
           2

    示例 2:

    输入: 
        3
       / \
      0   4
       \
        2
       /
      1

      L = 1
      R = 3

    输出: 
          3
         / 
       2   
      /
     1

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/trim-a-binary-search-tree
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    */
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return null;
            if(R<root.val)
            {
                return TrimBST(root.left, L, R);
            }
            if(L>root.val)
            {
                return TrimBST(root.right, L, R);
            }
            if(root.left!=null)
            {
                if(root.left.val < L)
                {
                    root.left = TrimBST(root.left.right, L, R);
                }
                else
                {
                    root.left = TrimBST(root.left, L, R);
                }
            }
            if(root.right!=null)
            {
                if(root.right.val > R)
                {
                    root.right = TrimBST(root.right.left, L, R);
                }
                else
                {
                    root.right = TrimBST(root.right, L, R);
                }
            }
            return root;
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
