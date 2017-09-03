/*
 385. Mini Parser
DescriptionSubmissionsSolutions

    Total Accepted: 12800 Total Submissions: 42655 Difficulty: Medium Contributor: LeetCode 

Given a nested list of integers represented as a string, implement a parser to deserialize it.

Each element is either an integer, or a list -- whose elements may also be integers or other lists.

Note: You may assume that the string is well-formed:

    String is non-empty.
    String does not contain white spaces.
    String contains only digits 0-9, [, - ,, ].

Example 1:

Given s = "324",

You should return a NestedInteger object which contains a single integer 324.

Example 2:

Given s = "[123,[456,[789]]]",

Return a NestedInteger object containing a nested list with 2 elements:

1. An integer containing value 123.
2. A nested list containing two elements:
    i.  An integer containing value 456.
    ii. A nested list with one element:
         a. An integer containing value 789.
*/


/*
An Java Iterative Solution

This approach will just iterate through every char in the string (no recursion).

    If encounters '[', push current NestedInteger to stack and start a new one.
    If encounters ']', end current NestedInteger and pop a NestedInteger from stack to continue.
    If encounters ',', append a new number to curr NestedInteger, if this comma is not right after a brackets.
    Update index l and r, where l shall point to the start of a integer substring, while r shall points to the end+1 of substring.

Java Code:
*/
public NestedInteger deserialize(String s) {
    if (s.isEmpty())
        return null;
    if (s.charAt(0) != '[') // ERROR: special case
        return new NestedInteger(Integer.valueOf(s));
        
    Stack<NestedInteger> stack = new Stack<>();
    NestedInteger curr = null;
    int l = 0; // l shall point to the start of a number substring; 
               // r shall point to the end+1 of a number substring
    for (int r = 0; r < s.length(); r++) {
        char ch = s.charAt(r);
        if (ch == '[') {
            if (curr != null) {
                stack.push(curr);
            }
            curr = new NestedInteger();
            l = r+1;
        } else if (ch == ']') {
            String num = s.substring(l, r);
            if (!num.isEmpty())
                curr.add(new NestedInteger(Integer.valueOf(num)));
            if (!stack.isEmpty()) {
                NestedInteger pop = stack.pop();
                pop.add(curr);
                curr = pop;
            }
            l = r+1;
        } else if (ch == ',') {
            if (s.charAt(r-1) != ']') {
                String num = s.substring(l, r);
                curr.add(new NestedInteger(Integer.valueOf(num)));
            }
            l = r+1;
        }
    }
    
    return curr;
}

/**
Python using eval:
**/
def deserialize(self, s):
    def nestedInteger(x):
        if isinstance(x, int):
            return NestedInteger(x)
        lst = NestedInteger()
        for y in x:
            lst.add(nestedInteger(y))
        return lst
    return nestedInteger(eval(s))
/*
Python one-liner

def deserialize(self, s):
    return NestedInteger(s) if isinstance(s, int) else reduce(lambda a, x: a.add(self.deserialize(x)) or a, s, NestedInteger()) if isinstance(s, list) else self.deserialize(eval(s))

Python Golf (136 bytes or 31 bytes)

class Solution:deserialize=d=lambda S,s,N=NestedInteger:s<[]and N(s)or s<''and reduce(lambda a,x:a.add(S.d(x))or a,s,N())or S.d(eval(s))

Or abusing how the judge judges (yes, this gets accepted):

class Solution:deserialize=eval

Python parsing char by char

Here I turned the input string into a list with sentinel for convenience.
*/
def deserialize(self, s):
    def nestedInteger():
        num = ''
        while s[-1] in '1234567890-':
            num += s.pop()
        if num:
            return NestedInteger(int(num))
        s.pop()
        lst = NestedInteger()
        while s[-1] != ']':
            lst.add(nestedInteger())
            if s[-1] == ',':
                s.pop()
        s.pop()
        return lst
    s = list(' ' + s[::-1])
    return nestedInteger()

	
//Python Stack
debug = False
class Solution(object):
    def deserialize(self, s):
        """
        :type s: str
        :rtype: NestedInteger
        """
        stack = []
        i = 0
        last = ""
        def updateStack(str):
            if str != "":
                if debug: print 'Adding', str,'as Integer to level ', len(stack)
                par = stack.pop()
                ni = NestedInteger(int(str))
                par.add(ni)
                stack.append(par)
        
        while i < len(s):
            if s[i] == '[':
                # add a new level to the data structure
                stack.append(NestedInteger())
                if debug: print 'Level ', len(stack)
            elif s[i] == ']':
                # add last to parent if last is not empty
                updateStack(last)
                last = ""
                # remove a level and add to super parent if not outermost
                if len(stack) > 1:
                    par = stack.pop()
                    superpar = stack.pop()
                    superpar.add(par)
                    stack.append(superpar)
                    if debug: print 'Level ', len(stack)
            elif s[i] == ',':
                # add a new new integer to last list and insert back
                updateStack(last)
                last = ""
            else: 
                last += s[i]
                if debug:print last
            i += 1
            
        if len(stack) > 0:
            return stack.pop()
        return NestedInteger(int(last))
		
/*
C# 
*/


public NestedInteger Deserialize(string s)
{
	if (s[0] != '[')
	{
	return new NestedInteger(int.Parse(s));
	}

    Stack<NestedInteger> stack = new Stack<NestedInteger>();
    NestedInteger curr = new NestedInteger();
    stack.Push(curr);

    int start = 1;
    int pos = 1;

    while (pos < s.Length)
    {
        char ch = s[pos];

        if (ch == '[')
        {
            var nested = new NestedInteger();
            stack.Peek().Add(nested);
            stack.Push(nested);
            start = pos + 1;
        }
        else if (ch == ',' || ch == ']')
        {
            if (pos > start)
            {
                string current = s.Substring(start, pos - start);
                int val = int.Parse(current);
                stack.Peek().Add(new NestedInteger(val));
            }

            start = pos + 1;

            if (ch == ']')
                stack.Pop();

        }

        pos++;
    }

    return curr;
}

