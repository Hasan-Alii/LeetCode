public class Solution {
    public bool AreOccurrencesEqual(string s) {
        int[] frequency = new int[26];
        int comparer = 0;
        for (int i = 0; i< s.Length; i++)
        {
            comparer = s[i] - 'a';
            frequency[s[i] - 'a'] += 1;
        }
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[comparer] != frequency[i] && frequency[i] != 0)
                return false;
        }
        return true;
    }
}
