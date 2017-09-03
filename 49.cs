/*49. Group Anagrams
DescriptionHintsSubmissionsSolutions
Discuss   Editorial Solution Pick One
Given an array of strings, group anagrams together.

For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
Return:

[
  ["ate", "eat","tea"],
  ["nat","tan"],
  ["bat"]
]
Note: All inputs will be in lower-case.*/
//C#
public class Solution {
	public IList<IList<string>> GroupAnagrams(string[] strs) {
		IList<IList<string>> res = new List<IList<string>>();
		Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
		foreach(string str in strs)
		{
			char[] chararr = str.ToCharArray();
			Array.Sort(chararr);
			string key = new string(chararr);
			if(!dic.ContainsKey(key))
			{
				dic.Add(key, new List<string>());
			}

			dic[key].Add(str);
		}

		foreach(List<string> values in dic.Values)
		{
			res.Add(values);
		}

		return res;
	}
}

//java

public class Solution {
    Map<String, List<String>> map = new HashMap<>();

    public List<List<String>> groupAnagrams(String[] strs) {
        for(String s : strs){
            char[] c = s.toCharArray();
            Arrays.sort(c); 
            String key = new String(c);
            if(!map.containsKey(key)){
                map.put(key, new ArrayList<>());
            }
            map.get(key).add(s);
        }

        return new ArrayList<List<String>>(map.values());
    }
}
