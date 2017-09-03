/*
84. Largest Rectangle in Histogram 

 Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.


Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].


The largest rectangle is shown in the shaded area, which has area = 10 unit.

For example,
Given heights = [2,1,5,6,2,3],
return 10.

Subscribe to see which companies asked this question.

*/

public class Solution {
    public int largestRectangleArea(int[] height) {
        int len = height.length;
        Stack<Integer> s = new Stack<Integer>();
        int maxArea = 0;
        for(int i = 0; i <= len; i++){
            int h = (i == len ? 0 : height[i]);
            if(s.isEmpty() || h >= height[s.peek()]){
                s.push(i);
            }else{
                int tp = s.pop();
                maxArea = Math.max(maxArea, height[tp] * (s.isEmpty() ? i : i - 1 - s.peek()));
                i--;
            }
        }
        return maxArea;
    }
}
 

public class Solution {
    public int LargestRectangleArea(int[] heights) {
     
        int len = heights.Length;
        Stack<int> s = new Stack<int>();
        int maxArea = 0;
        for(int i = 0; i <= len; i++){
            int h = (i == len ? 0 : heights[i]);
            if(s.Count==0 || h >= heights[s.Peek()]){
                s.Push(i);
            }else{
                int tp = s.Pop();
                maxArea = Math.Max(maxArea, heights[tp] * (s.Count==0 ? i : i - 1 - s.Peek()));
                i--;
            }
        }
        return maxArea;
    }
}
     