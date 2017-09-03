/*
Given a string representing the file system in the above format
return the length of the longest absolute path to file in the abstracted file system. 
If there is no file in the system, return 0.

The string "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext" represents:

dir
    subdir1
        file1.ext
        subsubdir1
    subdir2
        subsubdir2
            file2.ext

return 32; because of "dir/subdir2/subsubdir2/file2.ext"
*/

public class Solution {
    public int LengthLongestPath(string input) {
    Stack<int> stack = new Stack<int>();
        int result = 0;
        foreach (string s in input.Split('\n')) {
			
			/* \t 2 characters will be count as 1      the number of '\t' plus 1 indicates the level*/
            int level = s.LastIndexOf('\t') + 1;
			
			/*stack.Count != level   means the folder doesnt have a deeper path and the previous number of level should be removed*/
            while (stack.Count != level) {
                stack.Pop();
            }
            int len = s.Substring(level).Length;
            if (stack.Count==0) {
                stack.Push(len);
            } else {
			/*+1 means plus the symbol of '/'  dir/subdir2/subsubdir2/file2.ext*/
                stack.Push(stack.Peek() + len + 1);
            }
			/*if it's file contains '.', result recorded*/
            if (s.Contains(".")) {
                result = Math.Max(result, stack.Peek());
            }
        }
        return result;
    }
}
 