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
            string username = username_box.Text;
            string password = textBox2.Text;

            Staff_Login_acount staff_Login_Acount = new Staff_Login_acount();

            staff_Login_Acount.setUserName(username);
            staff_Login_Acount.setPassword(password);

            Staff_Login found = Login_Functions.Find_List_Staff(staff_Login_Acount);

            //Staff_Login_acount found = found_item.Value;
            if (found.getPassword() == password)
            {
                // Manager Forms
                Manager_Form frm = new Manager_Form();
                frm.found_item = found;
                this.Hide();
                frm.Show();
            }
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
