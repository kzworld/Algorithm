/*
365. Water and Jug Problem Medium

You are given two jugs with capacities x and y litres. There is an infinite amount of water supply available. You need to determine whether it is possible to measure exactly z litres using these two jugs.

If z liters of water is measurable, you must have z liters of water contained within one or both buckets by the end.

Operations allowed:

Fill any of the jugs completely with water.
Empty any of the jugs.
Pour water from one jug into another till the other jug is completely full or the first jug itself is empty.
Example 1: (From the famous "Die Hard" example)

Input: x = 3, y = 5, z = 4
Output: True
Example 2:

Input: x = 2, y = 6, z = 5
Output: False
*/

public class Solution {
   
        //求两个数的公约数: 16 , 24,用两者中较大值 % 较小值 = 结果，较大值=较小值，较小值=结果，直到较小值为0
	public int GCD(int x , int y)
	{
		if(x < y)
		{
			int temp = x;
			x = y;
			y = temp;
		}
		while(y>0)
		{
			int temp = x % y;
			x = y;
			y = temp;
		}
		return x;
	}

    public bool CanMeasureWater(int x, int y, int z) {
		//任意一个杯子体积为z或者两个杯子体积和为z，都是可以的
		if(z == x || z == y || x + y == z)
		{
			return true;
		}
		if(x < 0 || y < 0 || z < 0 || x + y < z)
		{
			return false;
		}
		int gcdNum = GCD(x , y);
		//如果z % x和y的最大公约数 为0，说明就是
		if(0 == z % gcdNum )
		{
			return true;
		}
		else
		{
			return false;
		}
	}    
}

//Python
题目大意：
给定两个容量分别为x和y升的罐子。提供无限容量的水。你需要判断用这两个罐子是否可以恰好量出z升的体积。

如果可以量出z升水，你最终需要将这些水装在其中的一个或者两个罐子中。

允许的操作包括：

将任意罐子灌满。
将任意罐子清空。
将任意罐子的水倒入另一个罐子，直到另一个罐子倒满或者自己为空为止。
测试用例如题目描述。

解题思路：
求最大公约数GCD（Greatest Common Divisor)。

如果x与y互质（最大公约数为1），则容量范围[1, x + y]之内的任意整数体积均可以通过适当的操作得到。

否则，记x与y的最大公约数为gcd，则可以获得的容量z只能为gcd的整数倍，且z <= x + y

简单的证明：

假设最终体积z = m * x + n * y（m与n为整数，可以为0或者为负）

令x = p * gcd, y = q * gcd，可知p与q互质。

则z = (m * p + n * q) * gcd

可以证明一定存在m, n，使得m * p + n * q = 1（p与q互质的性质，参见：裴蜀定理）

由此可知z一定是gcd的整数倍
Python代码：
class Solution(object):
    def canMeasureWater(self, x, y, z):
        """
        :type x: int
        :type y: int
        :type z: int
        :rtype: bool
        """
        if x > y: x, y = y, x
        gcd = self.gcd(x, y)
        if gcd == 0: return z == 0
        return z % gcd == 0 and z <= x + y

    def gcd(self, a, b):
        if a == 0: return b
        return self.gcd(b % a, a)
