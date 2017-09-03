/*144. Binary Tree Preorder Traversal

    Total Accepted: 138469
    Total Submissions: 333444
    Difficulty: Medium

Given a binary tree, return the preorder traversal of its nodes' values.

For example:
Given binary tree {1,#,2,3},

   1
    \
     2
    /
   3

return [1,2,3]. */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
	public IList<int> PreorderTraversal(TreeNode root) {
		/*
                1
            2           3
        4       5    6       7
        PreOrder 1245367
        */
        IList<int> res = new List<int>();
		Stack<TreeNode> stack = new Stack<TreeNode>();
		if(root == null) return res;

		stack.Push(root);
		while(stack.Count>0)
		{
			TreeNode curr = stack.Pop();
			res.Add(curr.val);
			if(curr.right!= null) stack.Push(curr.right);
			if(curr.left!= null) stack.Push(curr.left);
		}

		return res;
	}
}