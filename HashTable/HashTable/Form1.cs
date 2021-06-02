using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyHashTable<int> hashTableInt;
        MyHashTable<string> hashTableStr;
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (IntKey.Checked)
            {
                hashTableInt.Add(Convert.ToInt32(KeyValue.Text), Value.Text, hashInt(Convert.ToInt32(KeyValue.Text)));
                ViewTable.Text = hashTableInt.ToString();
            }
            else
            {
                hashTableStr.Add(KeyValue.Text, Value.Text, hashStr(KeyValue.Text));
                ViewTable.Text = hashTableStr.ToString();
            }
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            if (IntKey.Checked)
            {
                hashTableInt = new MyHashTable<int>(Convert.ToInt32(N_Value.Text));
                hashTableInt.setHash(hashInt);
            }
            else
            {
                hashTableStr = new MyHashTable<string>(Convert.ToInt32(N_Value.Text));
                hashTableStr.setHash(hashStr);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (IntKey.Checked)
            {
                hashTableInt.Delete(Convert.ToInt32(KeyValue.Text));
                ViewTable.Text = hashTableInt.ToString();
            }
            else
            {
                hashTableStr.Delete(KeyValue.Text);
                ViewTable.Text = hashTableStr.ToString();
            }
            
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            hashTableInt = null;
            hashTableStr = null;
            N_Value.Text = null;
            KeyValue.Text = null;
            ViewTable.Text = "";
        }


        private int hashInt(int key)
        {
            return key % 4;
        }
        private int hashStr(string key)
        {
            return key.Length % 4;
        }
    }
}
