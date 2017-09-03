/*
440. K-th Smallest in Lexicographical Order 
Given integers n and k, find the lexicographically k-th smallest integer in the range from 1 to n.

Note: 1 ≤ k ≤ n ≤ 109.

Example:

Input:
n: 13   k: 2

Output:
10

Explanation:
The lexicographical order is [1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9], so the second smallest number is

给定整数n和k，计算从1到n的整数中字典序第k小的数。

注意： 1 ≤ k ≤ n ≤ 10^9
*/


/*
解法I 直接构造法

初始令答案ans = 1，当k值＞0时执行循环：

计算ans与ans + 1之间的数字个数gap

若gap <= k：则令ans = ans + 1，k = k - gap

否则令ans = ans * 10，k = k - 1

当n, p, q = 35769, 3, 4时，findGap函数执行过程如下：

p        q         gap
3        4         1
30       40        11
300      400       111
3000     4000      1111
30000    40000     6881
*/
class Solution(object):
    def findKthNumber(self, n, k):
        """
        :type n: int
        :type k: int
        :rtype: int
        """
        ans = 1
        k -= 1
        while k > 0:
            gap = self.findGap(n, ans, ans + 1)
            if gap <= k:
                ans += 1
                k -= gap
            else:
                ans *= 10
                k -= 1
        return ans

    def findGap(self, n, p, q):
        gap = 0
        while p <= n:
            gap += max(0, min(n + 1, q) - p)
            p *= 10
            q *= 10
        return gap

/*
解法II 将整数1到n划分为3个区间分别求解

区间1：字典序 ≤ n

区间2：首位数 = n的首位数，且字典序 ＞ n

区间3：首位数 > n
*/
class Solution(object):
    def findKthNumber(self, n, k):
        """
        :type n: int
        :type k: int
        :rtype: int
        """
        if n < 10: return k
        sn = str(n)
        po = int('1' * len(sn))
        fd = int(sn[0])
        lo = (fd - 1) * po
        mi = lo + self.calcMi(n)
        hi = lo + self.calcHi(n)
        if k > hi:
            po /= 10
            k -= hi
            fc = (k - 1) / po + fd + 1
            k += fd * po
        elif k > mi:
            return self.solveMi(9 * po / 10, n / 10 + 1, k - mi - 1)
        else:
            fc = (k - 1) / po + 1
        return int(str(fc) + self.solve(9 * po / 10, k - (fc - 1) * po - 1))

    def calcMi(self, n):
        res = 1
        mask = 10 ** int(math.log(n, 10))
        while n > 9:
            res += 1 + n % mask
            n /= 10
            mask /= 10
        return res

    def calcHi(self, n):
        res = 1 + int('1' * (len(str(n)) - 1))
        mask = 10 ** int(math.log(n, 10))
        return res + n % mask

    def solve(self, n, k):
        if k == 0: return ''
        if n <= 10: return str(k - 1)
        po = int('1' * len(str(n)))
        fc = (k - 1) / po
        rest = self.solve(9 * po / 10, k - fc * po - 1)
        return str(fc) + rest

    def solveMi(self, n, k, r):
        if r <= n - k: return k + r
        return self.solveMi(n / 10, k / 10 + 1, r - n + k)


//Java
public class Solution {
	public int findKthNumber(int n, int k) {
		int curr = 1;
		k = k - 1;
		while (k > 0) {
			int steps = calSteps(n, curr, curr + 1);
			if (steps <= k) {
				curr += 1;
				k -= steps;
			} else {
				curr *= 10;
				k -= 1;
			}
		}
		return curr;
	}
	//use long in case of overflow
	public int calSteps(int n, long n1, long n2) {
		int steps = 0;
		while (n1 <= n) {
			steps += Math.min(n + 1, n2) - n1;
			n1 *= 10;
			n2 *= 10;
		}
		return steps;
	}
}

/*
 https://discuss.leetcode.com/topic/64624/concise-easy-to-understand-java-5ms-solution-with-explaination

Actually this is a denary tree (each node has 10 children). Find the kth element is to do a k steps preorder traverse of the tree.
0_1477293053966_upload-40379731-118a-4753-bed9-1cb372790d4b

Initially, image you are at node 1 (variable: curr),
the goal is move (k - 1) steps to the target node x. (substract steps from k after moving)
when k is down to 0, curr will be finally at node x, there you get the result.

we don't really need to do a exact k steps preorder traverse of the denary tree, the idea is to calculate the steps between curr and curr + 1 (neighbor nodes in same level), in order to skip some unnecessary moves.

Main function
Firstly, calculate how many steps curr need to move to curr + 1.

    if the steps <= k, we know we can move to curr + 1, and narrow down k to k - steps.

    else if the steps > k, that means the curr + 1 is actually behind the target node x in the preorder path, we can't jump to curr + 1. What we have to do is to move forward only 1 step (curr * 10 is always next preorder node) and repeat the iteration.

calSteps function

    how to calculate the steps between curr and curr + 1?
    Here we come up a idea to calculate by level.
    Let n1 = curr, n2 = curr + 1.
    n2 is always the next right node beside n1's right most node (who shares the same ancestor "curr")
    (refer to the pic, 2 is right next to 1, 20 is right next to 19, 200 is right next to 199).

    so, if n2 <= n, what means n1's right most node exists, we can simply add the number of nodes from n1 to n2 to steps.

    else if n2 > n, what means n (the biggest node) is on the path between n1 to n2, add (n + 1 - n1) to steps.

    organize this flow to "steps += Math.min(n + 1, n2) - n1; n1 *= 10; n2 *= 10;"

Here is the code snippet:
*/