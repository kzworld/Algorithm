/*
102. Binary Tree Level Order Traversal •Difficulty: Easy
Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
For example:
 Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its level order traversal as:

[
  [3],
  [9,20],
  [15,7]
]
*/

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        IList<IList<int>> res=new List<IList<int>>();
        if(root==null) return res;
        Queue<TreeNode> queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            IList<int> list=new List<int>();
            int count=queue.Count;
            for(int i=0;i<count;i++)
            {
                TreeNode curnode=queue.Dequeue();
                list.Add(curnode.val);
                if(curnode.left!=null) queue.Enqueue(curnode.left);
                if(curnode.right!=null) queue.Enqueue(curnode.right);
                
            }
            res.Add(list);
        }
        return res;
    }
}

/*
JS
*/
var levelOrder = function(root) {
  if (!root) return [];
  var array = [];
  search(root, 1);

  function search(root, level) {
    if (root) {
      if (array.length < level) {
        array.push([]);
      }
      var arr = array[level - 1];
      arr.push(root.val);
      search(root.left, level + 1);
      search(root.right, level + 1);
    } else {
      return;
    }
  }

  return array;
};