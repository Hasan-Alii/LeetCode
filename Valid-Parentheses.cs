public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
    {')', '('},
    {'}', '{'},
    {']', '['}
};
Stack<char> chars = new Stack<char>();
foreach (char c in s)
{
    if (closeToOpen.ContainsKey(c))
    {
        if (chars.Count > 0 && chars.Peek() == closeToOpen[c])
            chars.Pop();
        else
            return false;
        
    }else
        chars.Push(c);
}
return chars.Count == 0;
    }
}
