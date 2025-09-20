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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> sideView = new List<int>();
        Queue<TreeNode> currLvlQueue = new Queue<TreeNode>();
        if(root != null)
        currLvlQueue.Enqueue(root);
        else return sideView; 
        while (currLvlQueue.Count > 0)
        {
            // TreeNode rightSide = new TreeNode();
            TreeNode node = new TreeNode();
            for(int i = currLvlQueue.Count; i>0 ; i--)
            {
                node = currLvlQueue.Dequeue();
                if (node != null)
                {
                    // rightSide = node;
                    if (node.left != null) currLvlQueue.Enqueue(node.left);
                    if (node.right != null) currLvlQueue.Enqueue(node.right);

                }
            }
            if(node != null)
                    sideView.Add(node.val);
        }
        return sideView;
    }
}
