/*
 36. Valid Sudoku

    Total Accepted: 106202
    Total Submissions: 311659
    Difficulty: Medium
    Contributors: Admin

Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.

The Sudoku board could be partially filled, where empty cells are filled with the character '.'.


A partially filled sudoku which is valid.

Note:
A valid Sudoku board (partially filled) is not necessarily solvable. Only the filled cells need to be validated. 
*/

public class Solution {
    public bool IsValidSudoku(char[,] board) {
        for(int i=0;i<9;i++)
        {
            if(!IsValid(board,i,i,0,8) )return false;
            if(!IsValid(board,0,8,i,i) )return false;
        }
        
        for(int i=0;i<3;i++)
        {
             for(int j=0;j<3;j++)
            {
                 if(!IsValid(board,i*3,i*3+2,j*3,j*3+2))return false;
            }   
        }        
      return true;        
    }
    
    private bool IsValid(char[,] board,int rowstart,int rowend,int colstart,int colend)
    {
        HashSet<int> set = new HashSet<int>();
        for(int row=rowstart;row<=rowend;row++)
        {
            for(int col=colstart;col<=colend;col++)
            {
                if(board[row,col]!='.')
                {
                    if(!set.Add(board[row,col]))  return false;
                }
            }
        }
        return true;
    }
}