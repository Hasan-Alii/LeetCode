public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var res = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (var item in strs)
            {
                if (item.Length == i || item[i] != strs[0][i])
                {
                    return res;
                }
            }
            res += strs[0][i];
        }
        return res;
    }
}