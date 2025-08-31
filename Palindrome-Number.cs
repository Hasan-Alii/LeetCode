public class Solution {
    public bool IsPalindrome(int x) {
                char[] charArray = x.ToString().ToCharArray();
        Array.Reverse(charArray);
        var noraml = x.ToString();
        var reversed = new string(charArray);
        if(string.Equals(reversed, noraml))
            return true;
        return false;
    }
}
