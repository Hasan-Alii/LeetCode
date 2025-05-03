public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var seen = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.ContainsKey(nums[i]))
                return true;
            else
                seen[nums[i]] = i;
        }
        return false;
    }
}