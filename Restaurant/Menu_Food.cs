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
    public partial class Menu_Food : Form
    {
        public Staff_Login temp_login { get; set; }
        public Menu_Food()
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
            temp.temp_login = temp_login;
            temp.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_List_btn_Click(object sender, EventArgs e)
        {
            Staff_List_Form staff_List_Form = new Staff_List_Form();
            staff_List_Form.temp_login = temp_login;
            this.Hide();
            staff_List_Form.Show();
        }

        private void Salary_List_btn_Click(object sender, EventArgs e)
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

        private void Timetable_btn_Click(object sender, EventArgs e)
        {

        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            New_password_form frm = new New_password_form();
            frm.temp_login = temp_login;
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
