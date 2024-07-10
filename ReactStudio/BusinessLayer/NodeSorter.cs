using System.Collections;
using System.Windows.Forms;

namespace ReactStudio.BusinessLayer
{
    public class NodeSorter : IComparer
    {
        // Implement the Compare method that compares two nodes by name
        public int Compare(object x, object y)
        {
            // Cast the objects to TreeNode types
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;

            // Compare the node names using string.Compare and negate the result
            return -string.Compare(tx.Text, ty.Text);
        }
    }
}
