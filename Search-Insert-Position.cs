public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length - 1, mid = 0;
        if (target < nums[0])
            return 0;
        if (nums.Length < 3 && nums.Length != 1)
        {
            if (target <= nums[0])
                return 0;
            else if (target <= nums[1])
                return 1;
            else
                return 2;
        }
        while(left <= right)
        {
            if(target == nums[mid])
                return mid;
            else if (target < nums[mid])
            {
                right = mid - 1;
                mid = (right + left) / 2;
            }
            else
            {
                left = mid + 1;
                mid = (right + left) / 2;
            }
        }
        return target == nums[mid] ? mid : mid + 1;
    }
}
