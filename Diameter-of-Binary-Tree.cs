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
    int res= 0;
    public int dfs(TreeNode root){
                if (root == null) return 0;
                var left = dfs(root.left);
                var right = dfs(root.right);
                res = int.Max((left + right), res);
                return 1+int.Max(left, right);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        dfs(root);
        return res;
    }
}
