378. Kth Smallest Element in a Sorted Matrix

    Total Accepted: 9086
    Total Submissions: 22139
    Difficulty: Medium

Given a n x n matrix where each of the rows and columns are sorted in ascending order, find the kth smallest element in the matrix.

Note that it is the kth smallest element in the sorted order, not the kth distinct element.

Example:

matrix = [
   [ 1,  5,  9],
   [10, 11, 13],
   [12, 13, 15]
],
k = 8,

return 13.




public class Solution {
    public int KthSmallest(int[,] matrix, int k) {
        if(matrix==null) return 0;
        int yaxis=matrix.GetLength(0);
        int xaxis=matrix.GetLength(1);
        if(yaxis==0||xaxis==0) return 0;
        int[] arr = new int[yaxis*xaxis];
        
        int count=0;
        for(int y=0;y<yaxis;y++)
        {
            for(int x=0;x<xaxis;x++)
            {
               arr[count++]=matrix[y,x];
            }
        }
		/*Write into a new array and sort then get the value from new sorted array*/
        Array.Sort(arr);
        return arr[k-1];
    }
}