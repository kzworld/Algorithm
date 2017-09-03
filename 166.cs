/*166. Fraction to Recurring Decimal

    Total Accepted: 37086
    Total Submissions: 230525
    Difficulty: Medium

Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.

If the fractional part is repeating, enclose the repeating part in parentheses.

For example,

    Given numerator = 1, denominator = 2, return "0.5".
    Given numerator = 2, denominator = 1, return "2".
    Given numerator = 2, denominator = 3, return "0.(6)".
*/
public class Solution {
	public string FractionToDecimal(int numerator, int denominator) {
		if (numerator == 0) {
			return "0";
		}

		StringBuilder res = new StringBuilder();
		// "+" or "-"
        res.Append(((numerator > 0) ^ (denominator > 0)) ? "-" : "");
		long num = Math.Abs((long)numerator);
		long den = Math.Abs((long)denominator);

		// integral part
        res.Append(num / den);
		num %= den;
		if (num == 0) {
			return res.ToString();
		}

		// fractional part
        res.Append(".");

		//start 1/3    
		//HashSet<long> map = new HashSet<long>();
		//res.Add(num);
		//end
        Console.WriteLine("1  "+num);
		Dictionary<long, int> map = new Dictionary<long, int>();
		map.Add(num, res.Length);
		while (num != 0) {
			num *= 10;
			Console.WriteLine("2  "+num);
			res.Append(num / den);
			Console.WriteLine("3  "+num/den);
			num %= den;
			Console.WriteLine("4  "+num);
			if (map.ContainsKey(num)) {
				int index = map[num];
				res.Insert(index, "(");
				res.Append(")");
				break;
			}
			else {
				map.Add(num, res.Length);
			}
		}

		return res.ToString();
	}
}