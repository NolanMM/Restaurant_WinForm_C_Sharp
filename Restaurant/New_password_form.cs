using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Restaurant
{
    public partial class New_password_form : Form
    {
        public New_password_form()
        {
            InitializeComponent();
        }
        public Staff_Login temp_login { get; set; }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void New_password_btn_Click(object sender, EventArgs e)
        {
            Staff_Login temp_login = new Staff_Login();
            temp_login.setUserName(temp_login.getUserName());
            LinkedList<Staff_Login> list = Login_Functions.Create_Read_Account_Login_List();

            Staff_Login find_item = Login_Functions.Find_Item_by_username_Return_Node(temp_login, list);

            if(newpass_box.Text == confirm_text_box.Text)
            {
                string new_password = confirm_text_box.Text;
                find_item.setPassword(new_password);
                /* @Write the new information to the file */
                bool flag_file = Login_Functions.Write_To_File(list);
                if (flag_file == true)
                {
                    SuccessfullyMessage.Show();
                    Login_Form login_Form = new Login_Form();
                    this.Hide();
                    login_Form.Show();
                }
                else
                {
                    ErrorMessageSent.Show();
                }
            }
            else
            {
                Confirm_not_match.Show();
            }

        }

    }
}
