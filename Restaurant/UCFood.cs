using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class UCFood : UserControl
    {
        public UCFood()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            textBox4.Visible = true;
            button4.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            textBox5.Visible = true;
            button5.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            textBox6.Visible = true;
            button6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " $ Only";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + " $ Only";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text + " $ Only";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox4.Text + " $ Only";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = textBox5.Text + " $ Only";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = textBox6.Text + " $ Only";
        }
    }
}
