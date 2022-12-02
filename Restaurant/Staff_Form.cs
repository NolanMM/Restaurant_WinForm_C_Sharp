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
    public partial class Staff_Form : Form
    {
        public Staff_Login temp_login { get; set; }
        public Staff_Form()
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

        private void Restaurant_btn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelRestaurantSubmenu);
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfileSubmenu);
        }
    }
}
