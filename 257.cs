/*
257. Binary Tree Paths •Difficulty: Easy
Given a binary tree, return all root-to-leaf paths. 
For example, given the following binary tree: 
   1
 /   \
2     3
 \
  5
All root-to-leaf paths are: 
["1->2->5", "1->3"]
*/
public class Solution {
    public string path ="";    
    public IList<string> BinaryTreePaths(TreeNode root) {
        //Define List<string> to save the result
         List<string> res = new  List<string>();  
        
        //Process to generate the List<string>  
         rec(root, res);  
         
         //return the result
         return res;  
         }  
         
         private void rec(TreeNode root, List<string> res) {  
             //If root is null return list
             if(root==null) return;
             
             //If left root is null and right root is null return root value
             if(root.left==null && root.right==null) {  
                 path+=root.val;  
                 res.Add(path);  
                 return;  
                 } 
                
                //If left root is not null put the left root value to the end of result list 
                 path+=root.val; 
                 path+="->" ;  
                 int oriLen = path.Length;  
                 if(root.left!=null) rec(root.left, res);  
                 
                 //In the very bottom of the tree If the left root value is not null and the right root value is not null has to delete the left value by setting limitation on the length of the string.
                 path=path.Substring(0,oriLen);  
                 if(root.right!=null) rec(root.right, res);  
                 }  
    
}