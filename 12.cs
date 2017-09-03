/*12. Integer to Roman

    Total Accepted: 74809
    Total Submissions: 182534
    Difficulty: Medium

Given an integer, convert it to a roman numeral.

Input is guaranteed to be within the range from 1 to 3999.

Subscribe to see which companies asked this question
*/
public class Solution {
	public string IntToRoman(int num) {
		string[] M = { "", "M", "MM", "MMM" };
		string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
		string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
		string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
		return M[num/1000] + C[(num%1000)/100] + X[(num%100)/10] + I[num%10];
	}
}