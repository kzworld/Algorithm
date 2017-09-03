/*
 405. Convert a Number to Hexadecimal

    Total Accepted: 10432
    Total Submissions: 25548
    Difficulty: Easy
    Contributors: Admin

Given an integer, write an algorithm to convert it to hexadecimal. For negative integer, two’s complement method is used.

Note:

    All letters in hexadecimal (a-f) must be in lowercase.
    The hexadecimal string must not contain extra leading 0s. If the number is zero, it is represented by a single zero character '0'; otherwise, the first character in the hexadecimal string will not be the zero character.
    The given number is guaranteed to fit within the range of a 32-bit signed integer.
    You must not use any method provided by the library which converts/formats the number to hex directly.

Example 1:

Input:
26

Output:
"1a"

Example 2:

Input:
-1

Output:
"ffffffff"

*/

public class Solution {
	public string ToHex(int num) {
		string hex = string.Empty;
		uint unum = (uint)num;

		if (unum == 0)
		{
			return "0";
		}

		while (unum > 0)
		{
			uint y = unum % 16;

			if (y < 10)
			{
				hex = (char)(y + '0') + hex;
			}
			else
			{
				hex = (char)((y - 10) + 'a') + hex;
			}
			unum = unum >> 4;
		}

		return hex;
	}
}