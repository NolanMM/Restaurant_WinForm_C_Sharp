using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Salary_List_Form : Form
    {
        public Staff_Login temp_login { get; set; }
        public Salary_List_Form()
        {
            InitializeComponent();
            CustomizeDes();
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {

            LinkedList<Salary_Staff> temp = Salary_Functions.Read_The_Salary_From_File();

            string[] Split_List_Item = new string[11];
            Split_List_Item[0] = Username_box.Text;
            Split_List_Item[1] = firstname_box.Text;
            Split_List_Item[2] = Lastname_box.Text;
            Split_List_Item[3] = Salary_Box.Text;
            Split_List_Item[4] = Mon_box.Text;
            Split_List_Item[5] = Tue_box.Text;
            Split_List_Item[6] = Wed_box.Text;
            Split_List_Item[7] = Thur_box.Text;
            Split_List_Item[8] = Fri_box.Text;
            Split_List_Item[9] = Sat_box.Text;
            Split_List_Item[10] = Sun_box.Text;

            Salary_Staff salary = new Salary_Staff();
            salary.setUserName(Username_box.Text);
            salary.setFirstName(firstname_box.Text);
            salary.setLastName(Lastname_box.Text);
            float salary_float = (float)Convert.ToDouble(Salary_Box.Text);
            salary.set_Salary(salary_float);

            float mon = (float)Convert.ToDouble(Mon_box.Text);
            float tue = (float)Convert.ToDouble(Tue_box.Text);
            float wed = (float)Convert.ToDouble(Wed_box.Text);
            float thu = (float)Convert.ToDouble(Thur_box.Text);
            float fri = (float)Convert.ToDouble(Fri_box.Text);
            float sat = (float)Convert.ToDouble(Sat_box.Text);
            float sun = (float)Convert.ToDouble(Sun_box.Text);

            salary.set_Working_Hour_mon(mon);
            salary.set_Working_Hour_tue(tue);
            salary.set_Working_Hour_wed(wed);
            salary.set_Working_Hour_thur(thu);
            salary.set_Working_Hour_fri(fri);
            salary.set_Working_Hour_sat(sat);
            salary.set_Working_Hour_sun(sun);
            temp.AddFirst(salary);
            Salary_Functions.Store_The_Salary_To_File(temp);

            ListViewItem items = new ListViewItem(Split_List_Item);
            listView_inventory.Items.Add(items);
        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {
            if (listView_inventory.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to modify this item", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    LinkedList<Salary_Staff> temp = Salary_Functions.Read_The_Salary_From_File();
                    Salary_Staff staff_salary = Salary_Functions.Checking_Specific_Satff_In_Salary(listView_inventory.SelectedItems[0].Text);
                    temp.Remove(staff_salary);

                    staff_salary.setUserName(Username_box.Text);
                    staff_salary.setFirstName(firstname_box.Text);
                    staff_salary.setLastName(Lastname_box.Text);
                    float salary_float = (float)Convert.ToDouble(Salary_Box.Text);
                    staff_salary.set_Salary(salary_float);

                    float mon = (float)Convert.ToDouble(Mon_box.Text);
                    float tue = (float)Convert.ToDouble(Tue_box.Text);
                    float wed = (float)Convert.ToDouble(Wed_box.Text);
                    float thu = (float)Convert.ToDouble(Thur_box.Text);
                    float fri = (float)Convert.ToDouble(Fri_box.Text);
                    float sat = (float)Convert.ToDouble(Sat_box.Text);
                    float sun = (float)Convert.ToDouble(Sun_box.Text);

                    staff_salary.set_Working_Hour_mon(mon);
                    staff_salary.set_Working_Hour_tue(tue);
                    staff_salary.set_Working_Hour_wed(wed);
                    staff_salary.set_Working_Hour_thur(thu);
                    staff_salary.set_Working_Hour_fri(fri);
                    staff_salary.set_Working_Hour_sat(sat);
                    staff_salary.set_Working_Hour_sun(sun);
                    temp.AddFirst(staff_salary);
                    Salary_Functions.Store_The_Salary_To_File(temp);

                    listView_inventory.Items.Remove(listView_inventory.SelectedItems[0]);
                    string[] Split_List_Item = new string[11];
                    Split_List_Item[0] = Username_box.Text;
                    Split_List_Item[1] = firstname_box.Text;
                    Split_List_Item[2] = Lastname_box.Text;
                    Split_List_Item[3] = Salary_Box.Text;
                    Split_List_Item[4] = Mon_box.Text;
                    Split_List_Item[5] = Tue_box.Text;
                    Split_List_Item[6] = Wed_box.Text;
                    Split_List_Item[7] = Thur_box.Text;
                    Split_List_Item[8] = Fri_box.Text;
                    Split_List_Item[9] = Sat_box.Text;
                    Split_List_Item[10] = Sun_box.Text;

                    ListViewItem items = new ListViewItem(Split_List_Item);
                    listView_inventory.Items.Add(items);
                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (listView_inventory.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to delete the item", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    LinkedList<Salary_Staff> temp = Salary_Functions.Read_The_Salary_From_File();
                    StreamWriter strm = File.CreateText("Salary.txt");
                    strm.Flush();
                    strm.Close();

                    Salary_Staff staff_salary = Salary_Functions.Checking_Specific_Satff_In_Salary(listView_inventory.SelectedItems[0].Text);
                    temp.Remove(staff_salary);
                    Salary_Functions.Store_The_Salary_To_File(temp);

                    listView_inventory.Items.Remove(listView_inventory.SelectedItems[0]);
                }
            }
        }

        private void Salary_List_Form_Load(object sender, EventArgs e)
        {
            LinkedList<Salary_Staff> temp = Salary_Functions.Read_The_Salary_From_File();
            int number_of_item_in_file = temp.Count();

            if (number_of_item_in_file > 0)
            {
                foreach (Salary_Staff item in temp)
                {
                    string[] Split_List_Item = new string[11];
                    Split_List_Item[0] = Username_box.Text;
                    Split_List_Item[1] = firstname_box.Text;
                    Split_List_Item[2] = Lastname_box.Text;
                    Split_List_Item[3] = Salary_Box.Text;
                    Split_List_Item[4] = Mon_box.Text;
                    Split_List_Item[5] = Tue_box.Text;
                    Split_List_Item[6] = Wed_box.Text;
                    Split_List_Item[7] = Thur_box.Text;
                    Split_List_Item[8] = Fri_box.Text;
                    Split_List_Item[9] = Sat_box.Text;
                    Split_List_Item[10] = Sun_box.Text;
                    ListViewItem items = new ListViewItem(Split_List_Item);
                    listView_inventory.Items.Add(items);
                }
            }
            else
            {
                string[] Split_List_Item = new string[11];
                Split_List_Item[0] = "Blank";
                Split_List_Item[1] = "Blank";
                Split_List_Item[2] = "Blank";
                Split_List_Item[3] = "Blank";
                Split_List_Item[4] = "Blank";
                Split_List_Item[5] = "Blank";
                Split_List_Item[6] = "Blank";
                Split_List_Item[7] = "Blank";
                Split_List_Item[8] = "Blank";
                Split_List_Item[9] = "Blank";
                Split_List_Item[10] = "Blank";
                ListViewItem items = new ListViewItem(Split_List_Item);
                listView_inventory.Items.Add(items);
            }
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
            Financial financial_Form = new Financial();
            financial_Form.found_item = temp_login;
            this.Hide();
            financial_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff_List_Form staff_List_Form = new Staff_List_Form();
            staff_List_Form.temp_login = temp_login;
            this.Hide();
            staff_List_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            New_password_form frm = new New_password_form();
            frm.temp_login = temp_login;
            this.Hide();
            frm.Show();
        }

        private void Timetable_btn_Click(object sender, EventArgs e)
        {

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
