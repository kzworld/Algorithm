/*
66. Plus One •Difficulty: Easy
Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
You may assume the integer do not contain any leading zero, except the number 0 itself.
The digits are stored such that the most significant digit is at the head of the list.
*/
public class Solution {
    public int[] PlusOne(int[] digits) {
         List<int> result=new List<int>();
        int one=1;
        for(int i=digits.Length-1;i>=0;i--)
        {
            one+=digits[i];
            digits[i]=one%10;
            one/=10;
        }
        if(one>0) result.Add(1);
        foreach(int i in digits)
        result.Add(i);
        return result.ToArray();
    }
}
/*
Javascript
*/
var plusOne = function(digits) {
    var carry = 1;
    for(var i = digits.length - 1 ; i >= 0 ; i--){
        digits[i]+=carry;
         if(digits[i]==10) 
         {
             digits[i]=0;
            carry=1;
         }
         else
         {
          carry=0;
         }
    }
    if(carry == 1){
        digits.unshift(carry); 
    }
    return digits;
};