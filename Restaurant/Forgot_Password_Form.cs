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
    public partial class Forgot_Password_Form : Form
    {
        public Forgot_Password_Form()
        {
            InitializeComponent();
        }

        string OTP_Code;
        string username;
        private void Username_btn_Click(object sender, EventArgs e)
        {
            Staff_Login temp_login = new Staff_Login();
            string username = username_box.Text;
            temp_login.setUserName(username);

            /* @ Create new random variable to automatic generate new verify code when it needed */
            Random rand = new Random();
            string randomCode = rand.Next(999999).ToString();
            OTP_Code = randomCode;
            LinkedList<Staff_Login> list = Login_Functions.Create_Read_Account_Login_List();

            Staff_Login find_item = Login_Functions.Find_Item_by_username_Return_Node(temp_login, list);

            if (find_item != null)
            {
                username = find_item.getUserName();
                Forgot_Password.Send_Verify_Code(randomCode, find_item.getRecovery());
            }
            else
            {
                incorrect_username.Show();
            }
        }

        private void Check_OTP_btn_Click(object sender, EventArgs e)
        {
            /* @ Checking the verify code 3 times or 
             * @ Else logout and start from beginning due to the security 
             */
            string verify_code_input = OTP_box.Text;
            int count = 0;
            while (count >= 0)
            {
                if (count == 2)
                {
                    count = -1;
                    Wrong_Verify_code.Hide();
                    Too_many_Time_text.Show();
                    break;
                }
                if (verify_code_input.CompareTo(OTP_Code) == 0)
                {
                    New_password_form frm = new New_password_form();
                    frm.Username = username;
                    this.Hide();
                    frm.ShowDialog();
                }
                else { 
                    int times_input_left = 2 - count;
                    Wrong_Verify_code.Show();
                    count++; 
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();
            this.Hide();
            frm.ShowDialog();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}
