/*
415. Add Strings  Difficulty: Easy
Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.

Note: 
1.The length of both num1 and num2 is < 5100.
2.Both num1 and num2 contains only digits 0-9.
3.Both num1 and num2 does not contain any leading zero.
4.You must not use any built-in BigInteger library or convert the inputs to integer directly.
*/
public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        if (num1 == null || num2 == null) return null;

        StringBuilder sb = new StringBuilder();
        int carry = 0;
        int l1 = num1.Length - 1;
        int l2 = num2.Length - 1;

        while (l1 >= 0 || l2 >= 0)
        {
            int n1 = l1 >= 0 ? num1[l1] - '0' : 0;
            int n2 = l2 >= 0 ? num2[l2] - '0' : 0;
            int sum = n1 + n2 + carry;
            carry = sum > 9 ? 1 : 0;
            sb.Insert(0, sum % 10);
            l1--;
            l2--;
        }

        if (carry == 1) sb.Insert(0, 1);

        return sb.ToString();
    }
}