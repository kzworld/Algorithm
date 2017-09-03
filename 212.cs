/*
212. Word Search II
 Given a 2D board and a list of words from the dictionary, find all words in the board.

Each word must be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once in a word.

For example,
Given words = ["oath","pea","eat","rain"] and board =

[
  ['o','a','a','n'],
  ['e','t','a','e'],
  ['i','h','k','r'],
  ['i','f','l','v']
]

Return ["eat","oath"].

Note:
You may assume that all inputs are consist of lowercase letters a-z. 

Intuitively, start from every cell and try to build a word in the dictionary. Backtracking (dfs) is the powerful way to exhaust every possible ways. Apparently, we need to do pruning when current character is not in any word.

    How do we instantly know the current character is invalid? HashMap?
    How do we instantly know what's the next valid character? LinkedList?
    But the next character can be chosen from a list of characters. "Mutil-LinkedList"?

Combing them, Trie is the natural choice. Notice that:

    TrieNode is all we need. search and startsWith are useless.
    No need to store character at TrieNode. c.next[i] != null is enough.
    Never use c1 + c2 + c3. Use StringBuilder.
    No need to use O(n^2) extra space visited[m][n].
    No need to use StringBuilder. Storing word itself at leaf node is enough.
    No need to use HashSet to de-duplicate. Use "one time search" trie.

For more explanations, check out dietpepsi's blog.
Code Optimization

UPDATE: Thanks to @dietpepsi we further improved from 17ms to 15ms.

    59ms: Use search and startsWith in Trie class like this popular solution.
    33ms: Remove Trie class which unnecessarily starts from root in every dfs call.
    30ms: Use w.toCharArray() instead of w.charAt(i).
    22ms: Use StringBuilder instead of c1 + c2 + c3.
    20ms: Remove StringBuilder completely by storing word instead of boolean in TrieNode.
    20ms: Remove visited[m][n] completely by modifying board[i][j] = '#' directly.
    18ms: check validity, e.g., if(i > 0) dfs(...), before going to the next dfs.
    17ms: De-duplicate c - a with one variable i.
    15ms: Remove HashSet completely. dietpepsi's idea is awesome.

The final run time is 15ms. Hope it helps!
*/

public class Solution {
    
    public IList<string> FindWords(char[,] board, string[] words) 
    {
		List<string> res = new List<string>();
		TrieNode root = buildTrie(words);
		for (int i = 0; i < board.GetLength(0); i++) {
			for (int j = 0; j < board.GetLength(1); j++) {
				dfs (board, i, j, root, res);
			}
		}
		return res;
    }

    public void dfs(char[,] board, int i, int j, TrieNode p, List<string> res) {
		char c = board[i,j];
		if (c == '#' || p.next[c - 'a'] == null) return;
		p = p.next[c - 'a'];
		if (p.word != null) {   // found one
			res.Add(p.word);
			p.word = null;     // de-duplicate
		}
	
		board[i,j] = '#';
		if (i > 0) dfs(board, i - 1, j ,p, res); 
		if (j > 0) dfs(board, i, j - 1, p, res);
		if (i < board.GetLength(0) - 1) dfs(board, i + 1, j, p, res); 
		if (j < board.GetLength(1) - 1) dfs(board, i, j + 1, p, res); 
		board[i,j] = c;
    }

	public TrieNode buildTrie(string[] words) {
		TrieNode root = new TrieNode();
		foreach (string w in words) {
			TrieNode p = root;
			foreach(char c in w.ToCharArray()) 
			{
				int i = c - 'a';
				if (p.next[i] == null) 
					p.next[i] = new TrieNode();
				p = p.next[i];
		}
		p.word = w;
		}
		return root;
	}
    
    public class TrieNode {
           public TrieNode[] next = new TrieNode[26];
           public string word;
    }
}

//Python


class Solution:
    # @param {character[][]} board
    # @param {string[]} words
    # @return {string[]}
    def findWords(self, board, words):
    #make trie
        trie={}
        for w in words:
            t=trie
            for c in w:
                if c not in t:
                    t[c]={}
                t=t[c]
            t['#']='#'
        self.res=set()
        self.used=[[False]*len(board[0]) for _ in range(len(board))]
        for i in range(len(board)):
            for j in range(len(board[0])):
                self.find(board,i,j,trie,'')
        return list(self.res)
    
    def find(self,board,i,j,trie,pre):
        if '#' in trie:
            self.res.add(pre)
        if i<0 or i>=len(board) or j<0 or j>=len(board[0]):
            return
        if not self.used[i][j] and board[i][j] in trie:
            self.used[i][j]=True
            self.find(board,i+1,j,trie[board[i][j]],pre+board[i][j])
            self.find(board,i,j+1,trie[board[i][j]],pre+board[i][j])
            self.find(board,i-1,j,trie[board[i][j]],pre+board[i][j])
            self.find(board,i,j-1,trie[board[i][j]],pre+board[i][j])
            self.used[i][j]=False

