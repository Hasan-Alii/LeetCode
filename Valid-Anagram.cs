public class Solution {
    public bool IsAnagram(string s, string t) {
        var ss = s.ToCharArray();
        Array.Sort(ss);
        var tt = t.ToCharArray();
        Array.Sort(tt);
        return ss.SequenceEqual( tt);
    }
}