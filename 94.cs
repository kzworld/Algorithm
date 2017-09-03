94. Binary Tree Inorder Traversal

    Total Accepted: 143601
    Total Submissions: 345689
    Difficulty: Medium

Given a binary tree, return the inorder traversal of its nodes' values.

For example:
Given binary tree [1,null,2,3],

   1
    \
     2
    /
   3

return [1,3,2]. 



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
    public IList<int> InorderTraversal(TreeNode root) {
    IList<int> list = new List<int>();
    Stack<TreeNode> stack = new Stack<TreeNode>();
    TreeNode cur = root;

    while(cur!=null || stack.Count>0){
        while(cur!=null){
            stack.Push(cur);
            cur = cur.left;
        }
        cur = stack.Pop();
        list.Add(cur.val);
        cur = cur.right;
    }

    return list;
    }
    
}