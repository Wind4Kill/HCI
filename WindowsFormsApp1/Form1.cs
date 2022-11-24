using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "This is my default message";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "This is another default message";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Clear field"))
            {
                textBox1.Clear();
            }
            else if (comboBox1.SelectedItem.Equals("Copy text"))
            {
               Clipboard.SetText(textBox1.Text);
            }
            else if(comboBox1.SelectedItem.Equals("Paste text"))
            {
               textBox1.Paste();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                label2.Show();
                comboBox1.Show();
                bExecute.Show();
            }
            else
            {
                label2.Hide();
                comboBox1.Hide();
                bExecute.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label1.Show();
                textBox1.Show();
                bShow.Show();
                bDefault1.Show();
                bDefault2.Show();
            }
            else
            {
                label1.Hide();
                textBox1.Hide();
                bShow.Hide();
                bDefault1.Hide();
                bDefault2.Hide();
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                comboBox1.Enabled = true;
                bExecute.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                bExecute.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                textBox1.Enabled = true;
                bShow.Enabled = true;
                bDefault1.Enabled = true;
                bDefault2.Enabled = true;

            }
            else
            {
                textBox1.Enabled = false;
                bShow.Enabled = false;
                bDefault1.Enabled = false;
                bDefault2.Enabled = false;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int a, b;

            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox2.Text);

            Console.Beep(a, b);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Console.Beep(1000, 500);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
