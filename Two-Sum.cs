public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Hashtable seen = new Hashtable();
        int diff = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            diff = target - nums[i];
            if (seen.ContainsKey(diff))
                return new int [] {(int) seen[diff], i};
            else
                seen[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}