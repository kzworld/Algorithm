/*
118. Pascal's Triangle  Difficulty: Easy
Given numRows, generate the first numRows of Pascal's triangle.
For example, given numRows = 5,
 Return 
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
*/

/*
C#
*/
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<int> RowList=new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        if(numRows==1) 
        {
            RowList.Add(1);
            result.Add(RowList);
            return result;
        }        
        for(int i=0;i<numRows;i++)
        {
          RowList.Insert(0,1);
          for(int j=1;j<RowList.Count-1;j++)
          {
               RowList[j]=RowList[j]+RowList[j+1];
          }
           
          result.Add(new List<int>(RowList));
        }
        return result;
        
    }
}

/*
Java
*/
public class Solution {
    public List<List<Integer>> generate(int numRows) {
        List<Integer> RowList=new ArrayList<Integer>();
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(numRows==1) 
        {
            RowList.add(1);
            result.add(RowList);
            return result;
        }        
        for(int i=0;i<numRows;i++)
        {
          RowList.add(0,1);
          for(int j=1;j<RowList.size()-1;j++)
          {
               RowList.set(j,RowList.get(j)+RowList.get(j+1));
          }
           
          result.add(new ArrayList<Integer>(RowList));
        }
        return result;
    }
}

/*
Javascript
*/
var generate = function(numRows) {
    var result = [];
    for(var i=0; i<numRows; i++){
        result[i] = [];
    }
    for(i=0; i<numRows; i++){
        result[i][0] = result[i][i] = 1;
    }
    for(i=2; i<numRows; i++){
        for(var j=1; j<i; j++){
            result[i][j] = result[i-1][j-1] + result[i-1][j];
        }
    }
    return result;
};