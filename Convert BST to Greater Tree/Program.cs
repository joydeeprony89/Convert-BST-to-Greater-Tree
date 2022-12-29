// See https://aka.ms/new-console-template for more information

// https://leetcode.com/problems/convert-bst-to-greater-tree/description/
Console.WriteLine("Hello, World!");
Solution s = new Solution();
TreeNode root = new TreeNode(4);

root.left = new TreeNode(1);
root.left.left = new TreeNode(0);
root.left.right = new TreeNode(2);
root.left.right.right = new TreeNode(3);

root.right= new TreeNode(6);
root.right.left = new TreeNode(5);
root.right.right = new TreeNode(7);
root.right.right.right = new TreeNode(8);

var answer = s.ConvertBST(root);

public class TreeNode
{
  public int val;
  public TreeNode left;
  public TreeNode right;
  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
  {
    this.val = val;
    this.left = left;
    this.right = right;
  }
}

public class Solution
{
  public TreeNode ConvertBST(TreeNode root)
  {
    long sum = 0;
    void Dfs(TreeNode root)
    {
      // We need to do reverse inorder - right ->root->left
      if (root == null) return;
      Dfs(root.right);
      sum += root.val;
      root.val = (int)sum;
      Dfs(root.left);
    }
    Dfs(root);
    return root;
  }
}