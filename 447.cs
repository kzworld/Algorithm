/* 447. Number of Boomerangs

    Total Accepted: 3511
    Total Submissions: 8703
    Difficulty: Easy
    Contributors: alexander54

Given n points in the plane that are all pairwise distinct, a "boomerang" is a tuple of points (i, j, k) such that the distance between i and j equals the distance between i and k (the order of the tuple matters).

Find the number of boomerangs. You may assume that n will be at most 500 and coordinates of points are all in the range [-10000, 10000] (inclusive).

Example:

Input:
[[0,0],[1,0],[2,0]]

Output:
2

Explanation:
The two boomerangs are [[1,0],[0,0],[2,0]] and [[1,0],[2,0],[0,0]]
*/
public class Solution {
	public int NumberOfBoomerangs(int[, ] points) {
		int n = points.GetLength(0);
		int count = 0;

		for (int p0 = 0; p0 < n; p0++)
		{
			// Keep a lookup of the distance from p0 to all other points
			// if you find another point with same distance give that distance
			// a count of 1 (one other point), if you see another point of this
			// distance move count to 2 and so on.  
        Dictionary<int, int> distSqMap = new Dictionary<int, int>();
			for (int p1 = 0; p1 < n; p1++)
			{
				if (p1 == p0) continue;

				// avoid square root calculation - do distance check against distance square
            int distSq = (points[p0, 0] - points[p1, 0])*(points[p0, 0] - points[p1, 0])
                    + (points[p0, 1] - points[p1, 1])*(points[p0, 1] - points[p1, 1]);

				if (!distSqMap.ContainsKey(distSq))
				{
					distSqMap[distSq] = 0;
				}
				else
				{
					distSqMap[distSq]++;
				}
			}

			// count number of combinations for groups of equally distanced points
        foreach (int groupCount in distSqMap.Values)
			{
				count += groupCount * (groupCount + 1);
			}
		}

		return count;
	}
}