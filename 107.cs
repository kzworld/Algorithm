/*
107. Binary Tree Level Order Traversal II •Difficulty: Easy

Given a binary tree, return the bottom-up level order traversal of its nodes' values. 
(ie, from left to right, level by level from leaf to root).

For example:
 Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7

return its bottom-up level order traversal as:

[
  [15,7],
  [9,20],
  [3]
]

*/
public class Solution
{
    private IList<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        Stack<IList<int>> stack = new Stack<IList<int>>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int count = queue.Count;
            IList<int> curlevel = new List<int>();

            for (int i = 0; i < count; i++)
            {
                TreeNode curNode = queue.Dequeue();
                curlevel.Add(curNode.val);
                if (curNode.left != null) queue.Enqueue(curNode.left);
                if (curNode.right != null) queue.Enqueue(curNode.right);
            }
            stack.Push(curlevel);
        }
        while (stack.Count > 0)
        {
            result.Add(stack.Pop());
        }
        return result;
    }
}