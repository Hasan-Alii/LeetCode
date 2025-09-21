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
    bool balanceFactor;
    public bool IsBalanced(TreeNode root)
    {
        if(root == null) return true;
        balanceFactor = true;
        MaxDepth(root);
        return balanceFactor;
    }

    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        if(Math.Abs(left - right) > 1) {balanceFactor =  false;}
        return int.Max(left, right) + 1;
    }
}
