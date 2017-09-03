/*
306. Additive Number

    Total Accepted: 17790
    Total Submissions: 66116
    Difficulty: Medium
    Contributors: Admin

Additive number is a string whose digits can form additive sequence.

A valid additive sequence should contain at least three numbers. Except for the first two numbers, each subsequent number in the sequence must be the sum of the preceding two.

For example:
"112358" is an additive number because the digits can form an additive sequence: 1, 1, 2, 3, 5, 8.

1 + 1 = 2, 1 + 2 = 3, 2 + 3 = 5, 3 + 5 = 8

"199100199" is also an additive number, the additive sequence is: 1, 99, 100, 199.

1 + 99 = 100, 99 + 100 = 199

Note: Numbers in the additive sequence cannot have leading zeros, so sequence 1, 2, 03 or 1, 02, 3 is invalid.

Given a string containing only digits '0'-'9', write a function to determine if it's an additive number.

*/
public class Solution {
     public bool IsAdditiveNumber(string num)
        {
            int n = num.Length;
            for (int i = 1; i <= n / 2; i++)
            {
                if (num[0] == '0' && i > 1) return false;
                long x1 = long.Parse(num.Substring(0, i));
                for (int j = 1; Math.Max(j, i) <= n - i - j; j++)
                {
                    if (num[i] == '0' && j > 1) break;
                    long x2 = long.Parse(num.Substring(i, j));
                    if (isValid(x1, x2, j + i, num)) return true;
                }
            }

            return false;
        }

        private bool isValid(long x1, long x2, int start, string num)
        {
            if (start == num.Length) return true;
            x2 = x2 + x1;
            x1 = x2 - x1;
            string sum = x2.ToString();
            return num.Substring(start).StartsWith(sum) && isValid(x1, x2, start + sum.Length, num);
        }
}