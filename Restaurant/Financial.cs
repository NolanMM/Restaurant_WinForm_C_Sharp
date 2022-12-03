using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant.Financial_class;

namespace Restaurant
{
    public partial class Financial : Form
    {
        public Financial()
        {
            InitializeComponent();
            CustomizeDes();
        }

        public Staff_Login found_item { get; set; }

        private void Financial_Load(object sender, EventArgs e)
        {
            LinkedList<Financial_Restaurant> temp = Financial_Functions.Read_The_Financial_From_File();

            OrdersTextBox.Text = Financial_Functions.ReturnAllOrdersAsString(temp);

            TotalIncomeLabel.Text = Financial_Functions.ReturnTotalIncome(temp) + "$";
            TotalLastMonthLabel.Text = Financial_Functions.ReturnIncomeForLastMonth(temp) + "$";
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
            temp.temp_login = found_item;
            temp.Show();
            this.Hide();
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Inventory_Form frm = new Inventory_Form();
            frm.temp_login = found_item;
            this.Hide();
            frm.Show();
        }

        private void Security_btn_Click(object sender, EventArgs e)
        {
            Security_Form frm = new Security_Form();
            frm.temp_login = found_item;
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Financial financial_Form = new Financial();
            financial_Form.found_item = found_item;
            this.Hide();
            financial_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff_List_Form staff_List_Form = new Staff_List_Form();
            staff_List_Form.temp_login = found_item;
            this.Hide();
            staff_List_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary_List_Form frm = new Salary_List_Form();
            frm.temp_login = found_item;
            this.Hide();
            frm.Show();
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            Salary frm = new Salary();
            frm.temp_login_staff = found_item;
            this.Hide();
            frm.Show();
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            New_password_form frm = new New_password_form();
            frm.temp_login = found_item;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
