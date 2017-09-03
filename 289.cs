/*289. Game of Life

    Total Accepted: 26265
    Total Submissions: 73624
    Difficulty: Medium

According to the Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."

Given a board with m by n cells, each cell has an initial state live (1) or dead (0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):

    Any live cell with fewer than two live neighbors dies, as if caused by under-population.
    Any live cell with two or three live neighbors lives on to the next generation.
    Any live cell with more than three live neighbors dies, as if by over-population..
    Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

Write a function to compute the next state (after one update) of the board given its current state.

Follow up:

    Could you solve it in-place? Remember that the board needs to be updated at the same time: You cannot update some cells first and then use their updated values to update other cells.
    In this question, we represent the board using a 2D array. In principle, the board is infinite, which would cause problems when the active area encroaches the border of the array. How would you address these problems?

	
	
/*

    Any live cell with fewer than two live neighbors dies, as if caused by under-population.
    Any live cell with two or three live neighbors lives on to the next generation.
    Any live cell with more than three live neighbors dies, as if by over-population..
    Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

*/

public class Solution {
	private const int live = 1, dead = 0, livetolive = 1, livetodead = 4, deadtolive = 3;
	/*each live cell contains two statues.   still live, and gonna die.*/
   private bool isliveold(int obj)
	{
		return obj == livetolive||obj == livetodead;
	}

	private bool islivenew(int obj)
	{
		return obj == livetolive||obj == deadtolive;
	}

	/*Get the number cells around the board[y,x]*/
    private int getroundnum(int[, ] board, int y, int x)
	{
		int yaxis = board.GetLength(0);
		int xaxis = board.GetLength(1);
		int ystart = y-1>= 0?y-1:y;
		int xstart = x-1>= 0?x-1:x;
		int yend = y+1<yaxis?y+1:yaxis-1;
		int xend = x+1<xaxis?x+1:xaxis-1;
		int sum = 0;
		for(int ys = ystart;ys<= yend;ys++)
		{
			for(int xs = xstart;xs<= xend;xs++)
			{
				if(ys == y&&xs == x)continue;
				if(isliveold(board[ys, xs])) sum++;
			}
		}

		return sum;
	}

	public void GameOfLife(int[, ] board)
	{
		if(board == null) return;
		int yaxis = board.GetLength(0);
		int xaxis = board.GetLength(1);
		if(yaxis == 0||xaxis == 0) return;
		for(int y = 0;y<yaxis;y++)
		{
			for(int x = 0;x<xaxis;x++)
			{
				int sum = getroundnum(board, y, x);
				if(isliveold(board[y, x]))
				{
					board[y, x] = sum == 2||sum == 3?livetolive:livetodead;
				}				else
				{
					board[y, x] = sum == 3?deadtolive:dead;
				}
			}
		}

		for(int y = 0;y<yaxis;y++)
		{
			for(int x = 0;x<xaxis;x++)
			{
				board[y, x] = islivenew(board[y, x])?live:dead;
			}
		}
	}
}