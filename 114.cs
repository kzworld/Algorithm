/*114. Flatten Binary Tree to Linked List

    Total Accepted: 102577
    Total Submissions: 310646
    Difficulty: Medium
    Contributors: Admin

Given a binary tree, flatten it to a linked list in-place.

For example,
Given

         1
        / \
       2   5
      / \   \
     3   4   6

The flattened tree should look like:

   1
    \
     2
      \
       3
        \
         4
          \
           5
            \
             6

click to show hints.
Hints:

If you notice carefully in the flattened tree, each node's right child points to the next node of a pre-order traversal.
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
public class Solution {
	public void Flatten(TreeNode root) {
		Helper(root, null);
	}

	private TreeNode Helper(TreeNode node, TreeNode prev) {
		if(node == null) {
			return prev;
		}

		TreeNode right = node.right;
		if(prev != null) {
			prev.left = null;
			prev.right = node;
		}

		prev = node;
		prev = Helper(node.left, prev);
		return Helper(right, prev);
	}
}