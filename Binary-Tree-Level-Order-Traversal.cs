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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> nums = new List<IList<int>>();
        Queue<TreeNode> treeLevels = new Queue<TreeNode>();
        treeLevels.Enqueue(root);
        while (treeLevels.Count > 0)
        {
            IList<int> currLvl = new List<int>();
            for (int i = treeLevels.Count; i>0; i--)
            {
                TreeNode node = treeLevels.Dequeue();
                if (node != null)
                {
                    currLvl.Add(node.val);
                    if(node.left!=null) treeLevels.Enqueue(node.left);
                    if(node.right!=null) treeLevels.Enqueue(node.right);
                }
            }
            if(currLvl.Count > 0) nums.Add(currLvl);
        }
        return nums;
    }
}
