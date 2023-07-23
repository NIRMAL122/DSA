using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
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
    public class AllPossibleFullBinaryTrees
    {
        public IList<TreeNode> AllPossibleFBT(int n)
        {
            Dictionary<int, List<TreeNode>> dp = new Dictionary<int, List<TreeNode>>()
        {
            { 0, new List<TreeNode>() },
            { 1, new List<TreeNode>() { new TreeNode(0) } }
        };

            List<TreeNode> Backtrack(int num)
            {
                if (dp.ContainsKey(num))
                    return dp[num];

                List<TreeNode> res = new List<TreeNode>();
                for (int l = 0; l < num; l++)
                {
                    int r = num - 1 - l;
                    List<TreeNode> leftTrees = Backtrack(l);
                    List<TreeNode> rightTrees = Backtrack(r);

                    foreach (TreeNode t1 in leftTrees)
                    {
                        foreach (TreeNode t2 in rightTrees)
                        {
                            res.Add(new TreeNode(0, t1, t2));
                        }
                    }
                }
                dp[num] = res;
                return res;
            }

            return Backtrack(n);
        }
    }
}
