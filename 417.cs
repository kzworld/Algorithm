 /*
  417. Pacific Atlantic Water Flow  Medium 

Given an m x n matrix of non-negative integers representing the height of each unit cell in a continent, the "Pacific ocean" touches the left and top edges of the matrix and the "Atlantic ocean" touches the right and bottom edges.

Water can only flow in four directions (up, down, left, or right) from a cell to another one with height equal or lower.

Find the list of grid coordinates where water can flow to both the Pacific and Atlantic ocean.

Note:

    The order of returned grid coordinates does not matter.
    Both m and n are less than 150.

Example:

Given the following 5x5 matrix:

  Pacific ~   ~   ~   ~   ~ 
       ~  1   2   2   3  (5) *
       ~  3   2   3  (4) (4) *
       ~  2   4  (5)  3   1  *
       ~ (6) (7)  1   4   5  *
       ~ (5)  1   1   2   4  *
          *   *   *   *   * Atlantic

Return:

[[0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]] (positions with parentheses in above matrix).

Subscribe to see which companies asked this question.

 */
 
 /*
 JAVA dfs 
 */
 public class Solution {
    
   public List<int[]> pacificAtlantic(int[][] matrix) {
        List<int[]> res = new LinkedList<>();
        if(matrix == null || matrix.length == 0 || matrix[0].length == 0){
            return res;
        }
        int n = matrix.length, m = matrix[0].length;
        boolean[][]pacific = new boolean[n][m];
        boolean[][]atlantic = new boolean[n][m];
        for(int i=0; i<n; i++){
            dfs(matrix, pacific, Integer.MIN_VALUE, i, 0);
            dfs(matrix, atlantic, Integer.MIN_VALUE, i, m-1);
        }
        for(int i=0; i<m; i++){
            dfs(matrix, pacific, Integer.MIN_VALUE, 0, i);
            dfs(matrix, atlantic, Integer.MIN_VALUE, n-1, i);
        }
        for (int i = 0; i < n; i++) 
            for (int j = 0; j < m; j++) 
                if (pacific[i][j] && atlantic[i][j]) 
                    res.add(new int[] {i, j});
        return res;
    }
    
    int[][]dir = new int[][]{{0,1},{0,-1},{1,0},{-1,0}};    
    public void dfs(int[][]matrix, boolean[][]visited, int height, int x, int y){
        int n = matrix.length, m = matrix[0].length;
        if(x<0 || x>=n || y<0 || y>=m || visited[x][y] || matrix[x][y] < height)
            return;
        visited[x][y] = true;
        for(int[]d:dir){
            dfs(matrix, visited, matrix[x][y], x+d[0], y+d[1]);
        }
    }
}

/*
python
*/
class Solution(object):
    def pacificAtlantic(self, matrix):
        """
        :type matrix: List[List[int]]
        :rtype: List[List[int]]
        """
        if not matrix: return []
        self.directions = [(1,0),(-1,0),(0,1),(0,-1)]
        m = len(matrix)
        n = len(matrix[0])
        p_visited = [[False for _ in range(n)] for _ in range(m)]        
        a_visited = [[False for _ in range(n)] for _ in range(m)]
        result = []
        
        for i in range(m):
            # p_visited[i][0] = True
            # a_visited[i][n-1] = True
            self.dfs(matrix, i, 0, p_visited, m, n)
            self.dfs(matrix, i, n-1, a_visited, m, n)
        for j in range(n):
            # p_visited[0][j] = True
            # a_visited[m-1][j] = True
            self.dfs(matrix, 0, j, p_visited, m, n)
            self.dfs(matrix, m-1, j, a_visited, m, n)
            
        for i in range(m):
            for j in range(n):
                if p_visited[i][j] and a_visited[i][j]:
                    result.append([i,j])
        return result
                
                
    def dfs(self, matrix, i, j, visited, m, n):
        # when dfs called, meaning its caller already verified this point 
        visited[i][j] = True
        for dir in self.directions:
            x, y = i + dir[0], j + dir[1]
            if x < 0 or x >= m or y < 0 or y >= n or visited[x][y] or matrix[x][y] < matrix[i][j]:
                continue
            self.dfs(matrix, x, y, visited, m, n)

//Python Solution 2
class Solution(object):
	def pacificAtlantic(self, matrix):
		def fill(ocean, stack):
			while stack:
				r,c = stack.pop()
				if (r,c) in ocean: continue
				ocean.add((r,c))
				stack.extend([
					[nr, nc] for nr, nc in [[r-1,c], [r+1,c], [r,c-1], [r,c+1]]
					if 0 <= nr < m and 0 <= nc < n and matrix[r][c] <= matrix[nr][nc]])
					
		if not matrix or not matrix[0]:	return []
		m, n = len(matrix), len(matrix[0])
		pacific, atlantic = set(), set()
		pstack = [[r,0] for r in xrange(m)] + [[0,c] for c in xrange(1,n)]
		astack = [[r,n-1] for r in xrange(m)] + [[m-1,c] for c in xrange(n-1)]

		fill(pacific, pstack)
		fill(atlantic, astack)
		
		return [list(x) for x in pacific&atlantic]

		
//Java
public List<int[]> pacificAtlantic(int[][] matrix) {
    List<int[]> result=new ArrayList<int[]>();
    if(matrix.length==0||matrix[0].length==0) return result;
    int height=matrix.length,width=matrix[0].length;
    boolean [][]Pacific=new boolean[height][width],Atlantic=new boolean[height][width];
    for(int i=0;i<height;i++) {
        recursiveMark(Pacific,matrix,i,0,0); //We start from left edge of Pacific
        recursiveMark(Atlantic,matrix,i,width-1,0); //We start from right edge of Atlantic
    }
    for(int j=0;j<width;j++) {
        recursiveMark(Pacific,matrix,0,j,0); //We start from top edge of Pacific
        recursiveMark(Atlantic,matrix,height-1,j,0); //We start from bot edge of Atlantic
    }
    for(int i=0;i<height;i++)
      for(int j=0;j<width;j++){
          if(Pacific[i][j]&&Atlantic[i][j]) {
              int []newOne={i,j};
              result.add(newOne);
          }
      }
    return result;
}

public void recursiveMark(boolean [][]map,int[][]matrix,int i,int j,int pre){ 
    if(i<0||j<0||i>=map.length||j>=map[0].length) return;
    if(map[i][j]==true) return; //When this is visited before, we quit.
    int current=matrix[i][j];
    if(current>=pre) map[i][j]=true;
    else return;
    recursiveMark(map,matrix,i-1,j,current);
    recursiveMark(map,matrix,i+1,j,current);
    recursiveMark(map,matrix,i,j-1,current);
    recursiveMark(map,matrix,i,j+1,current);
}

//C#
public class Solution {
    public IList<int[]> PacificAtlantic(int[,] matrix) 
	{        
		IList<int[]> result=new List<int[]>();
		if(matrix.GetLength(0)==0||matrix.GetLength(1)==0) return result;
		int height=matrix.GetLength(0),width=matrix.GetLength(1);
		bool[,] Pacific=new bool[height,width],Atlantic=new bool[height,width];
		for(int i=0;i<height;i++) {
			recursiveMark(Pacific,matrix,i,0,0); //We start from left edge of Pacific
			recursiveMark(Atlantic,matrix,i,width-1,0); //We start from right edge of Atlantic
		}
		for(int j=0;j<width;j++) {
			recursiveMark(Pacific,matrix,0,j,0); //We start from top edge of Pacific
			recursiveMark(Atlantic,matrix,height-1,j,0); //We start from bot edge of Atlantic
		}
		for(int i=0;i<height;i++)
		for(int j=0;j<width;j++){
			if(Pacific[i,j]&&Atlantic[i,j]) {
				int[] newOne={i,j};
				result.Add(newOne);
			}
		}
		return result;
	}
	
	public void recursiveMark(bool [,]map,int[,]matrix,int i,int j,int pre)
	{ 
		if(i<0||j<0||i>=map.GetLength(0)||j>=map.GetLength(1)) return;
		if(map[i,j]==true) return; //When this is visited before, we quit.
		int current=matrix[i,j];
		if(current>=pre) map[i,j]=true;
		else return;
		recursiveMark(map,matrix,i-1,j,current);
		recursiveMark(map,matrix,i+1,j,current);
		recursiveMark(map,matrix,i,j-1,current);
		recursiveMark(map,matrix,i,j+1,current);
	}
}