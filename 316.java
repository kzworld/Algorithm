/*
316. Remove Duplicate Letters Add to List
DescriptionHintsSubmissionsSolutions
Total Accepted: 28576
Total Submissions: 98230
Difficulty: Hard
Contributor: LeetCode
Given a string which contains only lowercase letters, remove duplicate letters so that every letter appear once and only once. You must make sure your result is the smallest in lexicographical order among all possible results.

Example:
Given "bcabc"
Return "abc"

Given "cbacdcbc"
Return "acdb"
*/
/*Solution
for "cbacdcbc", we counts each letter's index:

a----2
b----1,6
c----0,3,5,7
d----4
we go from a to d, to find the first letter who has a index smaller than the largest index of the rest. Here, index 2 of letter a is smaller than 6, 7, 4, so we first pick a; then we remove all index smaller than 2, and we have:

b----6
c----3,5,7
d----4
the next round we pick c not b, why ? cuz 6 of b is larger than 4, but 3 of c is smaller than 4 and 6.

b---6
d---4
then we pick d and b to form "acdb"

O(n) time to count index, and as we only have 26 letters, it's about O(26 * 26) to find a candidate letter and O(n) time to remove all index. So I think the running time is O(n).
*/
public class Solution {
    public String removeDuplicateLetters(String s) {
        HashMap<Character, ArrayList<Integer>> counts = new HashMap<Character, ArrayList<Integer>>();
        ArrayList<Character> keys = new ArrayList<Character>();
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (!counts.containsKey(c)) {
                counts.put(c, new ArrayList<Integer>());
                keys.add(c);
            }
            counts.get(c).add(i);
        }
        Collections.sort(keys);
        StringBuilder sb = new StringBuilder();
        while (!counts.isEmpty()) {
            boolean found = true;
            for (int i = 0; i < keys.size(); i++) {
                int index = counts.get(keys.get(i)).get(0);
                for (int j = 0; j < keys.size(); j++) {
                    ArrayList<Integer> count = counts.get(keys.get(j));
                    if (count.get(count.size() - 1) < index) {
                        found = false;
                        break;
                    }
                }
                if (found) {
                    sb.append(keys.get(i));
                    counts.remove(keys.get(i));
                    keys.remove(i);
                    for (int j = 0; j < keys.size(); j++) {
                        ArrayList<Integer> count = counts.get(keys.get(j));
                        while (count.get(0) < index) {
                            count.remove(0);
                        }
                    }
                    break;
                }
                found = true;
            }
        }
        return sb.toString();
    }
}