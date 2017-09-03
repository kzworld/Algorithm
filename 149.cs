/* 149. Max Points on a Line    Difficulty: Hard
Given n points on a 2D plane, find the maximum number of points that lie on the same straight line.
*/
/**
 * Definition for a point.
 * public class Point {
 *     public int x;
 *     public int y;
 *     public Point() { x = 0; y = 0; }
 *     public Point(int a, int b) { x = a; y = b; }
 * }
 */
public class Solution {
	public int MaxPoints(Point[] points) {
		var max = 0;
		foreach (var point in points)
		{
			var hashtable = new Dictionary<double, int>();
			var samePointNumber = 0;
			foreach (var anotherPoint in points)
			{
				if (point.x == anotherPoint.x && point.y == anotherPoint.y)
				{
					samePointNumber++;
					continue;
				}

				var k = (point.y - anotherPoint.y) * 1.0 / (point.x - anotherPoint.x);
				if (hashtable.ContainsKey(k))
				{
					hashtable[k]++;
				}
				else
				{
					hashtable.Add(k, 1);
				}
			}
			max = Math.Max(max, samePointNumber);
			max = hashtable.Values.Select(value => value + samePointNumber).Concat(new[] { max }).Max();
		}
		return max;
	}
}