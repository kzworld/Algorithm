/*
101 Symmetric Tree •Difficulty: Easy
Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
For example, this binary tree [1,2,2,3,4,4,3] is symmetric: 
    1
   / \
  2   2
 / \ / \
3  4 4  3

But the following [1,2,2,null,3,null,3] is not:

    1
   / \
  2   2
   \   \
   3    3
Note:
 Bonus points if you could solve it both recursively and iteratively. 

*/
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        return root == null || Judge(root.left, root.right);
    }

    private bool Judge(TreeNode left, TreeNode right)
    {
        if (left == null || right == null) return left == right;
        if (left.val != right.val) return false;
        return Judge(left.left, right.right) && Judge(left.right, right.left);
    }
}

/*javascript*/
var isSymmetric = function(root) {
    if(root===null) return true;
    var subfunc=function(left,right){
        if(left===null||right===null) return left==right;
        if(left.val!=right.val)return false;
        return subfunc(left.left,right.right)&&subfunc(left.right,right.left);
    }
    return subfunc(root.left,root.right);
};