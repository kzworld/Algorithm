/*
434. Number of Segments in a String •Difficulty: Easy
Count the number of segments in a string, where a segment is defined to be a contiguous sequence of non-space characters.
Please note that the string does not contain any non-printable characters.

Example:
Input: "Hello, my name is John"
Output: 5
*/
string[] str = s.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
return str.Length;