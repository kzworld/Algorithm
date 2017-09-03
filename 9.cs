/*
9. Palindrome Number  Difficulty: Easy

Determine whether an integer is a palindrome. Do this without extra space.
*/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        //In Case X Is Negative Number Return False;
        if (x < 0) return false;
        //In Case X is 1 Digit Number;
        if (x < 10) return true;

        int temp = x;
        int y = 0;

        while (x != 0)
        {
            y = y * 10 + x % 10;
            x /= 10;
        }
        return temp == y;
    }
}