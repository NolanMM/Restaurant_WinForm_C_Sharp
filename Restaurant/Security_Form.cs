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
            CustomizeDes();

        }
        private void CustomizeDes()
        {
            panelRestaurantSubmenu.Visible = false;
            panelProfileSubmenu.Visible = false;
        }
        private void hideMenu()
        {
            if (panelRestaurantSubmenu.Visible == true)
                panelRestaurantSubmenu.Visible = false;
            if (panelProfileSubmenu.Visible == true)
                panelProfileSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }

        public Staff_Login temp_login { get; set; }

        string serialDataIN;
        private void Led_On_Click_1(object sender, EventArgs e)
        {
            //serialPort1.PortName = comboBox1.Text;
            //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            //serialPort1.Open();
            serialPort1.Write("a");
            //serialPort1.Close();
        }

        private void Led_Off_Click_1(object sender, EventArgs e)
        {
            //serialPort1.PortName = comboBox1.Text;
            //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            //serialPort1.Open();
            serialPort1.Write("b");
            //serialPort1.Close();
        }

        private void Fan_On_Click_1(object sender, EventArgs e)
        {
            //serialPort1.PortName = comboBox1.Text;
            //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            //serialPort1.Open();
            serialPort1.Write("c");
            //serialPort1.Close();
        }

        private void Fan_Off_Click_1(object sender, EventArgs e)
        {
            //serialPort1.PortName = comboBox1.Text;
            //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            //serialPort1.Open();
            serialPort1.Write("d");
            //serialPort1.Close();
        }

        private void Humidity_Click_1(object sender, EventArgs e)
        {
            //serialPort1.PortName = comboBox1.Text;
            //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            //serialPort1.Open();
            serialDataIN = serialPort1.ReadLine().ToString();
            string input = serialDataIN;
            string[] List = input.Split(' ');
            Humidity_box.Text = List[0].ToString();
            //serialPort1.Close();
        }

        private void Therminal_Click_1(object sender, EventArgs e)
        {
            //serialPort1.PortName = comboBox1.Text;
            //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            //serialPort1.Open();
            serialDataIN = serialPort1.ReadLine().ToString();
            string input = serialDataIN;
            string[] List = input.Split(' ');
            Temperature_box.Text = List[1].ToString();
            //serialPort1.Close();
        }

        private void Open_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = 9600;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                if (serialPort1.PortName == null)
                {
                    MessageBox.Show("Please Choose The PORT COM3");
                }
                if(serialPort1.BaudRate == 0)
                {
                    MessageBox.Show("Please Choose The BaudRate 9600");
                }
                serialPort1.Open();
                textBox1.Text = "Connection connected successfully";
                textBox1.Text = "Connected";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            try
            {

                serialPort1.Close();
                textBox1.Text = "Connection disconnected successfully";
                textBox1.Text = "Disconnected";
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        private void Menu_food_btn_Click(object sender, EventArgs e)
        {
            Menu_Food temp = new Menu_Food();
            temp.temp_login = temp_login;
            temp.Show();
            this.Hide();
        }

        private void Restaurant_btn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelRestaurantSubmenu);
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfileSubmenu);
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Inventory_Form frm = new Inventory_Form();
            frm.temp_login = temp_login;
            this.Hide();
            frm.Show();
        }

        private void Security_btn_Click(object sender, EventArgs e)
        {
            Security_Form frm = new Security_Form();
            frm.temp_login = temp_login;
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff_List_Form staff_List_Form = new Staff_List_Form();
            staff_List_Form.temp_login = temp_login;
            this.Hide();
            staff_List_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary_List_Form frm = new Salary_List_Form();
            frm.temp_login = temp_login;
            this.Hide();
            frm.Show();
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            Salary frm = new Salary();
            frm.temp_login_staff = temp_login;
            this.Hide();
            frm.Show();
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            New_password_form frm = new New_password_form();
            frm.temp_login = temp_login;
            this.Hide();
            frm.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {

        }

        private void About_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
