/* 
8. String to Integer (atoi)  Difficulty: Easy

Implement atoi to convert a string to an integer.

*/
public class Solution
{
    public int MyAtoi(string str)
    {
        //In Case str is empty or ""
        if (str.Length < 1) return 0;

        long res = 0;
        int sign = 1;
        int pos = 0;
        //Eliminate ' ' From String 
        while (str[pos] == ' ' && pos < str.Length) pos++;
        //Get positive or negative sign
        if (str[pos] == '+' || str[pos] == '-')
        {
            sign = str[pos] == '+' ? 1 : -1;
            pos++;
        }

        //Get Following Digits And If Following Char Is Not Digit Then Break;
        while (pos < str.Length)
        {
            if (!Char.IsDigit(str[pos])) return (int)res * sign;
            res = res * 10 + (str[pos++] - '0') % 10;
            //In Case res Is int.MinValue which is (-1-int.MaxValue)
            if (res > int.MaxValue)
                return sign == 1 ? int.MaxValue : int.MinValue;
        }
        return (int)res * sign;
    }

}