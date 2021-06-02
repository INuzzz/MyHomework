using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tree<int> tree = new Tree<int>();
        int item;

        private void AddNode_Click(object sender, EventArgs e)
        {
            ViewTree.Text = "";
            item = Convert.ToInt32(textBoxNode.Text);
            tree.Add(item);
            ViewTree.Text = tree.ToString();
        }

        private void FindNode_Click(object sender, EventArgs e)
        {
            item = Convert.ToInt32(textBoxNode.Text);
            if (tree.Contains(item))
                ViewTree.Text += "\n"+ tree.Contains(item).ToString() + " -> " + tree.Find(item).value;
            else
                ViewTree.Text += "\n" + tree.Contains(item).ToString();
        }

        private void DeleteNode_Click(object sender, EventArgs e)
        {
            ViewTree.Text = "";
            item = Convert.ToInt32(textBoxNode.Text);
            tree.Delete(item);
            ViewTree.Text = tree.ToString();
        }

        private void CleanTree_Click(object sender, EventArgs e)
        {
            tree = new Tree<int>();
            ViewTree.Text = "";
            textBoxNode.Text = "";
        }
    }
}
