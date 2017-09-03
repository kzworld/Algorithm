/*6. ZigZag Conversion 
 Add to List

 Difficulty: Easy

The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility) 
P   A   H   N
A P L S I I G
Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows: 
string convert(string text, int nRows);
convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR". 
*/
public class Solution
{
    public string Convert(string s, int numRows)
    {
        //Initiate String Builder Array And Create Instance For Each String Builder Object
        StringBuilder[] sb = new StringBuilder[numRows];

        for (int i = 0; i < numRows; i++)
        {
            sb[i] = new StringBuilder();
        }

        //Set Start Index Position To 0
        int p = 0;

        while (p < s.Length)
        {
            for (int i = 0; i < numRows && p < s.Length; i++)
            {
                sb[i].Append(s[p++]);
            }
            for (int i = numRows - 2; i > 0 && p < s.Length; i--)
            {
                sb[i].Append(s[p++]);
            }
        }

        //Result String Builder Append Each Character In String Builder Arrays
        for (int i = 1; i < sb.Length; i++)
        {
            sb[0].Append(sb[i]);
        }
        return sb[0].ToString();
    }
}