/* 282. Expression Add Operators

    Total Accepted: 19933
    Total Submissions: 71965
    Difficulty: Hard
    Contributors: Admin

Given a string that contains only digits 0-9 and a target value, return all possibilities to add binary operators (not unary) +, -, or * between the digits so they evaluate to the target value.

Examples:

"123", 6 -> ["1+2+3", "1*2*3"] 
"232", 8 -> ["2*3+2", "2+3*2"]
"105", 5 -> ["1*0+5","10-5"]
"00", 0 -> ["0+0", "0-0", "0*0"]
"3456237490", 9191 -> []
*/
public class Solution {
	public IList<string> AddOperators(string num, int target) {
		IList<string> result = new List<string>();
		dfs(result, "", 0, 0, num, target);
		return result;
	}

	private void dfs(IList<string> result, string curStr, long curSum, long curHead, string curNum, long target) {
		if(curNum.Length == 0 && target - curSum - curHead == 0) result.Add(curStr);
		for(int i = 1; i < 11 && i <= curNum.Length; i++) {
			string strNum = curNum.Substring(0, i); long lNum = Convert.ToInt64(strNum);
			if(lNum > int.MaxValue || curHead > int.MaxValue) break;
			if(curStr.Length == 0) dfs(result, strNum, 0, lNum, curNum.Substring(i), target);
			else {
				dfs(result, curStr + "*" + strNum, curSum, curHead * lNum, curNum.Substring(i), target);
				dfs(result, curStr + "+" + strNum, curSum + curHead, lNum, curNum.Substring(i), target);
				dfs(result, curStr + "-" + strNum, curSum + curHead, -lNum, curNum.Substring(i), target);
			}

			if(lNum == 0) break; // avoid result of "000"/"012" etc
		}
	}
}