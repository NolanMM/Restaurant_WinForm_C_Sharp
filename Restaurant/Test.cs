using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Restaurant
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        string OTP_Code;
        private void Username_btn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string randomCode = rand.Next(999999).ToString();
            OTP_Code = randomCode;
            string email = username_box.Text;
            Forgot_Password.Send_Verify_Code(randomCode, email);
        }

        private void Check_OTP_btn_Click(object sender, EventArgs e)
        {
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
                    label4.Show();
                }
                else
                {
                    int times_input_left = 2 - count;
                    Wrong_Verify_code.Show();
                    count++;
                }
            }
        }
    }
}
