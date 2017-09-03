/*
 406. Queue Reconstruction by Height

    Total Accepted: 11214
    Total Submissions: 20648
    Difficulty: Medium
    Contributors: Admin

Suppose you have a random list of people standing in a queue. Each person is described by a pair of integers (h, k), where h is the height of the person and k is the number of people in front of this person who have a height greater than or equal to h. Write an algorithm to reconstruct the queue.

Note:
The number of people is less than 1,100.

Example

Input:
[[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]

Output:
[[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]

*/
/*
Javascript
*/
var helpsort=function(a,b){
    if(a[0]!==b[0]){
        return a[0]-b[0];
    }
    else{
        return a[1]-b[1];
    }
    
};

var reconstructQueue = function(people) {
    people.sort(helpsort);
    var output=[];
    var n=people.length;
    for(var i=0;i<n;i++){
        var count=people[i][1];
        var tempcount=0;
        for(var j=0;j<n;j++){
           if(tempcount===count  && output[j]===undefined){
               break;
           }
           if(output[j]===undefined){
               tempcount++;
           }
           else{
               if(output[j][0]>=people[i][0]){
                   tempcount++;
               }
           }
       }
        output[j]=people[i];
    
    }
    return output;
};



/*
C#
*/
public class Solution {
	public int[, ] ReconstructQueue(int[, ] people) {
		List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
		List<Tuple<int, int>> temp2 = new List<Tuple<int, int>>(people.GetLength(0));
		for (int k = 0; k < people.GetLength(0); k++)
		{
			temp.Add(new Tuple<int, int>(people[k, 0], people[k, 1]));
		}
		//sort the numbers first by height and then by the position. height in descending order and position in ascending order.
            temp.Sort(
						(x, y) => 
						{ 
							int result = y.Item1.CompareTo(x.Item1); 
							return result == 0 ? x.Item2.CompareTo(y.Item2) : result; 
						}
					);
		for (int i = 0; i < temp.Count; i++)
		{
			temp2.Insert(temp[i].Item2, temp[i]);
		}

		for (int l = 0; l < people.GetLength(0); l++)
		{
			people[l, 0] = temp2[l].Item1;
			people[l, 1] = temp2[l].Item2;
		}

		//place the result back in original 2d array
            return people;
	}
}


/*
Java
*/
public class Solution {
   public int[][] reconstructQueue(int[][] people) {
        if (people == null || people.length <= 1) {
            return people;
        }
        Arrays.sort(people, new Comparator<int[]>() {
            public int compare(int[] o1, int[] o2) {
                return o1[0] == o2[0] ? o1[1] - o2[1] : o1[0] - o2[0];
            }
        });
        int n = people.length;
        int[][] ret = new int[n][];
        for (int i = 0; i < n; i++) {
            for (int j = 0, ahead = 0; j < n; j++) {
                if (ahead < people[i][1]) {
                    ahead += (ret[j] == null || ret[j][0] >= people[i][0]) ? 1 : 0;
                } else if (ret[j] == null) {
                    ret[j] = people[i];
                    break;
                }
            }
        }
        return ret;
    }
}
