/*
119. Pascal's Triangle II  Difficulty: Easy
Given an index k, return the kth row of the Pascal's triangle.
For example, given k = 3,
 Return [1,3,3,1]. 
Note:
 Could you optimize your algorithm to use only O(k) extra space? 
*/
/*
C#
*/
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> res=new List<int>();
        for(int i=0;i<rowIndex+1;i++)
        {
            res.Insert(0,1);
            for(int p=1;p<res.Count-1;p++)
            {
                res[p]+=res[p+1];
            }
        }
        return res;
    }
}

/*
Javascript
*/
var getRow = function(rowIndex) {
    var res=[];
    for(var i=0;i<rowIndex+1;i++)
    {
        res.unshift(1);
        for(var p=1;p<res.length-1;p++)
        {
            res[p]+=res[p+1];
        }
    }
    return res;
};