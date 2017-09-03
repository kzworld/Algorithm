/× 7. Reverse Integer 	 Add to List  Difficulty: Easy

Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321 
×/

public class Solution {
    public int Reverse(int x) {
        long res=0;
        while(x!=0)
        {
            res*=10;
            res+=x%10;
            x/=10;
            //Console.WriteLine(x);
            if(res>int.MaxValue||res<int.MinValue) return 0;
        }
        return (int)res;
    }
}