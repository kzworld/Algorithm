/*
 207. Course Schedule

    Total Accepted: 63581
    Total Submissions: 210460
    Difficulty: Medium
    Contributors: Admin

There are a total of n courses you have to take, labeled from 0 to n - 1.

Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]

Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?

For example:

2, [[1,0]]

There are a total of 2 courses to take. To take course 1 you should have finished course 0. So it is possible.

2, [[1,0],[0,1]]

There are a total of 2 courses to take. To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.
*/

public class Solution {
	public bool CanFinish(int numCourses, int[, ] prerequisites) {
		if (numCourses <= 0)
			return false;
		Queue<int> queue = new Queue<int>();
		int[] inDegree = new int[numCourses];
		for (int i = 0; i < prerequisites.GetLength(0); i++) {
			inDegree[prerequisites[i, 1]]++;
		}

		for (int i = 0; i < inDegree.Length; i++) {
			if (inDegree[i] == 0)
				queue.Enqueue(i);
		}

		while (queue.Count>0) {
			int x = queue.Dequeue();
			for (int i = 0; i < prerequisites.GetLength(0); i++) {
				if (x == prerequisites[i, 0]) {
					inDegree[prerequisites[i, 1]]--;
					if (inDegree[prerequisites[i, 1]] == 0)
						queue.Enqueue(prerequisites[i, 1]);
				}
			}
		}

		for (int i = 0; i < inDegree.Length; i++) {
			if (inDegree[i] != 0)
				return false;
		}

		return true;
	}
}