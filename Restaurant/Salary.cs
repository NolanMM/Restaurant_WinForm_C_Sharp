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
            CustomizeDes();
        }
        public Staff_Login temp_login_staff { get; set; }
        private void Salary_Load(object sender, EventArgs e)
        {
            Salary_Staff temp_login = Salary_Functions.Checking_Specific_Satff_In_Salary(temp_login_staff.getUserName()); ;
            Monday.Text = temp_login.get_Working_Hour_mon().ToString();
            Tuesday.Text = temp_login.get_Working_Hour_tue().ToString();
            Wednesday.Text = temp_login.get_Working_Hour_wed().ToString();
            Thursday.Text = temp_login.get_Working_Hour_thur().ToString();
            Friday.Text = temp_login.get_Working_Hour_fri().ToString();
            Saturday.Text = temp_login.get_Working_Hour_sat().ToString();
            Sunday.Text = temp_login.get_Working_Hour_sun().ToString();
            Rate_Per_Hour.Text = temp_login.get_Salary().ToString();

            float Total_Working = temp_login.get_Working_Hour_mon() + temp_login.get_Working_Hour_tue() + temp_login.get_Working_Hour_wed() + temp_login.get_Working_Hour_thur()
                + temp_login.get_Working_Hour_fri() + temp_login.get_Working_Hour_sat() + temp_login.get_Working_Hour_sun();
            Total_Working_Hour.Text = Total_Working.ToString();

            float Total = Total_Working * temp_login.get_Salary();
            Total_Salary.Text = Total.ToString();
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

        private void Restaurant_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRestaurantSubmenu);
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfileSubmenu);
        }

        private void Menu_food_btn_Click(object sender, EventArgs e)
        {
            Menu_Food temp = new Menu_Food();
            temp.temp_login = temp_login_staff;
            temp.Show();
            this.Hide();
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Inventory_Form frm = new Inventory_Form();
            frm.temp_login = temp_login_staff;
            this.Hide();
            frm.Show();
        }

        private void Security_btn_Click(object sender, EventArgs e)
        {
            Security_Form frm = new Security_Form();
            frm.temp_login = temp_login_staff;
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff_List_Form staff_List_Form = new Staff_List_Form();
            staff_List_Form.temp_login = temp_login_staff;
            this.Hide();
            staff_List_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary_List_Form frm = new Salary_List_Form();
            frm.temp_login = temp_login_staff;
            this.Hide();
            frm.Show();
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            Salary frm = new Salary();
            frm.temp_login_staff = temp_login_staff;
            this.Hide();
            frm.Show();
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            New_password_form frm = new New_password_form();
            frm.temp_login = temp_login_staff;
            this.Hide();
            frm.Show();
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {

        }

        private void About_btn_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
