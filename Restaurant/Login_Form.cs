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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            LinkedList<Staff_Login> list = Login_Functions.Create_Read_Account_Login_List();
            Staff_Login temp_login = new Staff_Login();
            Staff_Login found_item = new Staff_Login();
            bool checking = false;
            string username = username_box.Text;
            string password = password_input.Text;

            // Assign value to Node in Staff_login list
            temp_login.setUserName(username);
            temp_login.setPassword(password);

            (checking, found_item) = Login_Functions.Checking_Password(list, temp_login);

            if (checking == true && found_item.get_Role().CompareTo("Manager") == 0)
            {
                // Manager Forms
                Manager_Form frm = new Manager_Form();
                frm.found_item = found_item;
                this.Hide();
                frm.Show();
            }
            else if (checking == true && found_item.get_Role().CompareTo("Server") == 0 || checking == true && found_item.get_Role().CompareTo("Chef") == 0)
            {
                // Staff Forms
                Staff_Form frm = new Staff_Form();
                frm.temp_login = found_item;
                this.Hide();
                frm.Show();
            }
            else if (checking == true && found_item.get_Role().CompareTo("Chef") == 0 || checking == true && found_item.get_Role().CompareTo("Chef") == 0)
            { }
            else
                    {
                incorrect_message.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);   
        }

        private void forgot_password_btn_Click(object sender, EventArgs e)
        {
            Forgot_Password_Form frm = new Forgot_Password_Form();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
