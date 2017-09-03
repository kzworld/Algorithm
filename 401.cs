/*401. Binary Watch  Difficulty: Easy

A binary watch has 4 LEDs on the top which represent the hours (0-11), and the 6 LEDs on the bottom represent the minutes (0-59).

Each LED represents a zero or one, with the least significant bit on the right.
 
For example, the above binary watch reads "3:25".

Given a non-negative integer n which represents the number of LEDs that are currently on, return all possible times the watch could represent.

Example: 
Input: n = 1
Return: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32"]

Note:

•The order of output does not matter.
•The hour must not contain a leading zero, for example "01:00" is not valid, it should be "1:00".
•The minute must be consist of two digits and may contain a leading zero, for example "10:2" is not valid, it should be "10:02".
*/

public class Solution
{
    public IList<string> ReadBinaryWatch(int num)
    {
        List<string> result = new List<string>();
        this.Backtrack(num, 0, 0, 0, result);
        return result;
    }

    private void Backtrack(int num, int setBits, int currentIndex, int time, List<string> result)
    {
        var hours = time >> 6;
        var minutes = time & 0x3F;

        if (currentIndex == 11 || hours > 11 || minutes > 59)
            return;

        if (setBits == num)
        {
            result.Add(string.Format("{0}:{1:00}", hours, minutes));
            return;
        }

        this.Backtrack(num, setBits, currentIndex + 1, time, result);
        this.Backtrack(num, setBits + 1, currentIndex + 1, time |= (1 << currentIndex), result);
    }

}