public class Solution {
    public int Search(int[] nums, int target) {
        // int res = Array.BinarySearch(nums,target);
        // return res<0? -1: res; 
        
        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;
        
        int l = 0, r = nums.Length-1;

        while (l <= r)
        {
            int m = ((l + r) / 2);
            if (nums[m] == target)
                return m;
            if (nums[m] > target)
                r = m - 1;
            else
                l = m + 1;
        }
        return -1;
    }
}
