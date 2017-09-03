/*
 404. Sum of Left Leaves

    Total Accepted: 26140
    Total Submissions: 57383
    Difficulty: Easy
    Contributors: Admin

Find the sum of all left leaves in a given binary tree.

Example:

    3
   / \
  9  20
    /  \
   15   7

There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24.

*/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null) return 0;

        int ans = 0;

        if (root.left != null)
        {
            if (root.left.left == null && root.left.right == null) ans += root.left.val;
            else
                ans += SumOfLeftLeaves(root.left);
        }
        ans += SumOfLeftLeaves(root.right);

        return ans;
    }
}