using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTree
{
    class Tree<T>
    {
        TreeNode root;
        int count;

        public void Add(int value)
        {
            count++;
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                TreeNode newNode = new TreeNode(value);
                TreeNode node = root;
                while (true)
                {
                    if ((newNode.value < node.value) && (node.left == null))
                    {
                        node.left = newNode;
                        newNode.parent = node;
                        break;
                    }
                    else if ((newNode.value < node.value) && (node.left != null))
                    {
                        node = node.left;
                        continue;
                    }
                    else if ((newNode.value > node.value) && (node.right == null))
                    {
                        node.right = newNode;
                        newNode.parent = node;
                        break;
                    }
                    else if ((newNode.value > node.value) && (node.right != null))
                    {
                        node = node.right;
                        continue;
                    }
                    else if (newNode.value == node.value)
                    {
                        string message = "There can be no duplicate values in the tree";
                        MessageBox.Show(message);
                        count--;
                        break;
                    }
                }
            }
        }
        
        public bool Contains(int value)
        {
            TreeNode finding = null;
            FindNode(root, ref value, ref finding);
            if(finding == null)
                return false;
            else
                return true;
        }
        private TreeNode Find(int value)
        {
            TreeNode finding = root;
            FindNode(root, ref value, ref finding);
            return finding;
        }
        public void Delete(int value)
        {
            TreeNode deleteNode = Find(value);
            TreeNode node = root;
            if (deleteNode.left == null && deleteNode.right == null)
            {
                if (deleteNode.value < deleteNode.parent.value)
                    deleteNode.parent.left = null;
                else
                    deleteNode.parent.right = null;
            }
            else
            {
                if (deleteNode.left != null && deleteNode.right == null)
                {
                    node = deleteNode.left;
                }
                else if (deleteNode.right != null && deleteNode.left == null)
                {
                    node = deleteNode.right;
                }
                else if(deleteNode.left != null && deleteNode.right != null)
                {
                    node = deleteNode.left;
                    while (node.right != null)
                        node = node.right;

                    if (node.right != deleteNode.right)
                        node.right = deleteNode.right;
                    else
                        node.right = null;

                    if (node.left != deleteNode.left)
                        node.left = deleteNode.left;
                    else
                        node.left = null;
                    node.parent.right = null;
                }
                node.parent = deleteNode.parent;
                if (node.value < deleteNode.parent.value)
                    deleteNode.parent.left = node;
                else
                    deleteNode.parent.right = node;
            }
            count--;
        }
        public int Count()
        {
            return count;
        }
        public override string ToString()
        {
            string output = "";
            CLR(root, ref output);
            return output;
        }
        private void CLR(TreeNode node, ref string output)
        {
            if (node == null)
                return;

            output += node.value.ToString() + "_";
            CLR(node.left, ref output);
            CLR(node.right, ref output);
        }
        private void FindNode(TreeNode node, ref int value, ref TreeNode finding)
        {
            if (node == null)
                return;
            if(node.value==value)
                finding = node;
            if(value < node.value )
                FindNode(node.left, ref value, ref finding);
            else
                FindNode(node.right, ref value, ref finding);
        }
    }

    class TreeNode
    {
        public TreeNode parent;
        public TreeNode right;
        public TreeNode left;
        public int value;

        public TreeNode(int value)
        {
            this.value = value;
            parent = null;
            right = null;
            left = null;
        }
    }
}
