using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            test.Items.Clear();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cRemove_Click(object sender, EventArgs e)
        {
            if (test.SelectedIndex != -1)
            {
                test.Items.RemoveAt(test.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNote.Text))
            {
                test.Items.Add(txtNote.Text);
                txtNote.Clear();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
        