/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    IList<int> nums = new List<int>();
    private void DFS(TreeNode root)
    {
        if (root != null)
        {
            DFS(root.left);
            nums.Add(root.val);
            DFS(root.right);
        }
    }
    public int KthSmallest(TreeNode root, int k)
    {
        DFS(root);
        return nums[k - 1];
    }
}
