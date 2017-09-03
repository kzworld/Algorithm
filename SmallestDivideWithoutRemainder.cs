/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

using System;

public class Test
{
	public static int GetLCM(int from, int to) {
		var lcm = 1;
		var sum = lcm;
		for (int i = from; i <= to; i++) {
			Console.WriteLine("Checking for " + i + " with LCM " + lcm);
			while (sum % i != 0) {
				sum += lcm;
				Console.WriteLine("Extending sum to " + sum);
			}

			lcm = sum;
		}

		return lcm;
	}

	public static void Main()
	{
		Console.WriteLine("The lowest common multiple of 1 thru 20 is: " + GetLCM(1, 20));
	}
}

/*
Checking for 1 with LCM 1
Checking for 2 with LCM 1
Extending sum to 2
Checking for 3 with LCM 2
Extending sum to 4
Extending sum to 6
Checking for 4 with LCM 6
Extending sum to 12
Checking for 5 with LCM 12
Extending sum to 24
Extending sum to 36
Extending sum to 48
Extending sum to 60
Checking for 6 with LCM 60
Checking for 7 with LCM 60
Extending sum to 120
Extending sum to 180
Extending sum to 240
Extending sum to 300
Extending sum to 360
Extending sum to 420
Checking for 8 with LCM 420
Extending sum to 840
Checking for 9 with LCM 840
Extending sum to 1680
Extending sum to 2520
Checking for 10 with LCM 2520
Checking for 11 with LCM 2520
Extending sum to 5040
Extending sum to 7560
Extending sum to 10080
Extending sum to 12600
Extending sum to 15120
Extending sum to 17640
Extending sum to 20160
Extending sum to 22680
Extending sum to 25200
Extending sum to 27720
Checking for 12 with LCM 27720
Checking for 13 with LCM 27720
Extending sum to 55440
Extending sum to 83160
Extending sum to 110880
Extending sum to 138600
Extending sum to 166320
Extending sum to 194040
Extending sum to 221760
Extending sum to 249480
Extending sum to 277200
Extending sum to 304920
Extending sum to 332640
Extending sum to 360360
Checking for 14 with LCM 360360
Checking for 15 with LCM 360360
Checking for 16 with LCM 360360
Extending sum to 720720
Checking for 17 with LCM 720720
Extending sum to 1441440
Extending sum to 2162160
Extending sum to 2882880
Extending sum to 3603600
Extending sum to 4324320
Extending sum to 5045040
Extending sum to 5765760
Extending sum to 6486480
Extending sum to 7207200
Extending sum to 7927920
Extending sum to 8648640
Extending sum to 9369360
Extending sum to 10090080
Extending sum to 10810800
Extending sum to 11531520
Extending sum to 12252240
Checking for 18 with LCM 12252240
Checking for 19 with LCM 12252240
Extending sum to 24504480
Extending sum to 36756720
Extending sum to 49008960
Extending sum to 61261200
Extending sum to 73513440
Extending sum to 85765680
Extending sum to 98017920
Extending sum to 110270160
Extending sum to 122522400
Extending sum to 134774640
Extending sum to 147026880
Extending sum to 159279120
Extending sum to 171531360
Extending sum to 183783600
Extending sum to 196035840
Extending sum to 208288080
Extending sum to 220540320
Extending sum to 232792560
Checking for 20 with LCM 232792560
The lowest common multiple of 1 thru 20 is: 232792560
*/