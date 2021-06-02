using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        MyList<string> myList = new MyList<string>();
        string item;
        int index;
        

        private void Prepend_Click(object sender, EventArgs e)
        {
            ViewMyList.Text = "";
            item = ItemValue.Text;
            myList.Prepend(item);
            foreach(string element in myList)
                ViewMyList.Text += element + "\n";
        }

        private void RemoveAt_Click(object sender, EventArgs e)
        {
            ViewMyList.Text = "";
            item = ItemValue.Text;
            index = Convert.ToInt32(Index.Text);
            myList.RemoveAt(index);
            foreach (string element in myList)
                ViewMyList.Text += element + "\n";
        }

        private void Qppend_Click(object sender, EventArgs e)
        {
            ViewMyList.Text = "";
            item = ItemValue.Text;
            if(myList.first.value != null)
                myList.Qppend(item);
            else
                myList.Prepend(item);
            foreach (string element in myList)
                ViewMyList.Text += element + "\n";
        }

        private void ItemAt_Click(object sender, EventArgs e)
        {
            ViewMyList.Text = "";
            item = ItemValue.Text;
            index = Convert.ToInt32(Index.Text);
            foreach (string element in myList)
                ViewMyList.Text += element + "\n";
        }

        private void ClearnButton_Click(object sender, EventArgs e)
        {
            myList = null;
            myList = new MyList<string>();
            ViewMyList.Text = "";
            ViewSortMyList.Text = "";
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            ViewSortMyList.Text = "";
            foreach (string element in myList.Sort())
                ViewSortMyList.Text += element + "\n";
        }
    }
}
