/* 400. Nth Digit

    Total Accepted: 8821
    Total Submissions: 29213
    Difficulty: Easy
    Contributors: Admin

Find the nth digit of the infinite integer sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ...

Note:
n is positive and will fit within the range of a 32-bit signed integer (n < 2^31).

Example 1:

Input:
3

Output:
3

Example 2:

Input:
11

Output:
0

Explanation:
The 11th digit of the sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ... is a 0, which is part of the number 10.
*/
public class Solution {
	public int FindNthDigit(int n) {
		/**
     * 这里是找第n个数字(这里的数和数字有区别，数字可以理解为将所有数拼合成一个字符串后的第n为对应的数字（0-9)）
     * 这里首先分析一下位数和规律
     * 个位数：1-9，一共9个,共计9个数字
     * 2位数：10-99,一共90个，共计180个数字
     * 3位数：100-999，一共900个，共计270个数字
     * 4位数，1000-9999，一共9000个，共计36000个数字
     * 以此类推，
     * 这样我们就可以首先定位到是哪个数，再找到其对应的数字
     * */

		//小心溢出
        int digitType = 1;
		long digitNum = 9;
		//定位到是几位数
        while(n > digitNum*digitType) {
			n -= (int) digitNum*digitType;
			digitType++;
			digitNum*= 10;
		}

		//定位到是这些几位数里面的第几个的第几位
        int indexInSubRange = (n -1) / digitType;
		int indexInNum = (n -1) % digitType;
		//还原数字
        int num = (int)Math.Pow(10, digitType - 1) + indexInSubRange;
		string s = num.ToString();
		int result = s[indexInNum]-'0';
		return result;
	}
}