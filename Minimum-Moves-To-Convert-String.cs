public class Solution {
    public int MinimumMoves(string s) {
        int res = 0;
        for(int i = 0; i < s.Length; i++) {
            if (s[i] == 'X' && i + 3 <= s.Length && s[i + 2] == 'X')
            {
                res++;
                i += 2;
            } else if (s[i] == 'X' && i + 2 <= s.Length && s[i + 1] == 'X') {
                res++;
                i += 1;
            }
            else if (s[i] == 'X')
            {
                res++;
            }
        }
        return res;
    }
}
