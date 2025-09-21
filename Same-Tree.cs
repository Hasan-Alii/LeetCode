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
    public bool IsSameTree(TreeNode x, TreeNode y)
    {
        if(x == null && y == null) return true;
        if(x == null || y == null || x.val != y.val) return false;
        return IsSameTree(x.right, y.right) && IsSameTree(x.left, y.left);
    }
}
