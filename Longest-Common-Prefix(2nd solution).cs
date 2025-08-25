public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        char[] first = strs[0].ToCharArray();
        char[] last = strs[strs.Length - 1].ToCharArray();
        string res ="";
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != last[i])
                break;
            res += first[i];
        }
        return res;
    }
}
