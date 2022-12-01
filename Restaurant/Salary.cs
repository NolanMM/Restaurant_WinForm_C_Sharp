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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        public string Username { get; set; }
        private void Salary_Load(object sender, EventArgs e)
        {
            Salary_Staff find_item = Salary_Functions.Checking_Specific_Satff_In_Salary(Username);
            Monday.Text = find_item.get_Working_Hour_mon().ToString();
            Tuesday.Text = find_item.get_Working_Hour_tue().ToString();
            Wednesday.Text = find_item.get_Working_Hour_wed().ToString();
            Thursday.Text = find_item.get_Working_Hour_thur().ToString();
            Friday.Text = find_item.get_Working_Hour_fri().ToString();
            Saturday.Text = find_item.get_Working_Hour_sat().ToString();
            Sunday.Text = find_item.get_Working_Hour_sun().ToString();
            Rate_Per_Hour.Text = find_item.get_Salary().ToString();

            float Total_Working = find_item.get_Working_Hour_mon() + find_item.get_Working_Hour_tue() + find_item.get_Working_Hour_wed() + find_item.get_Working_Hour_thur()
                + find_item.get_Working_Hour_fri() + find_item.get_Working_Hour_sat() + find_item.get_Working_Hour_sun();
            Total_Working_Hour.Text = Total_Working.ToString();

            float Total = Total_Working * find_item.get_Salary();
            Total_Salary.Text = Total.ToString();
        }

    }
}
