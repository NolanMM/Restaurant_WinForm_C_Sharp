using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection.Emit;


namespace Restaurant
{
    public partial class Security_Form : Form
    {
        public Security_Form()
        {
            InitializeComponent();
        }

        string serialDataIN;
        private void Close_btn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch(Exception error) { MessageBox.Show(error.Message); }
        }

        

        private void Open_btn_Click(object sender, EventArgs e)
        {
            try
            {

                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Led_On_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            serialDataIN = serialPort1.ReadLine().ToString();
            textBox1.Text = serialDataIN;
            serialPort1.Write("a");
            serialPort1.Close();
        }

        private void Led_Off_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            serialPort1.Write("b");
            serialPort1.Close();
        }

        private void Fan_On_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            serialPort1.Write("c");
            serialPort1.Close();
        }

        private void Fan_Off_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            serialPort1.Write("d");
            serialPort1.Close();
        }

        private void Humidity_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            serialPort1.Write("e");
            serialPort1.Close();
        }

        private void Therminal_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            serialPort1.Write("f");
            serialPort1.Close();
        }
    }
}
