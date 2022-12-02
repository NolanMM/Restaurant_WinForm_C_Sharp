using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Staff_List_Form : Form
    {
        public Staff_List_Form()
        {
            InitializeComponent();
            CustomizeDes();
        }
        public Staff_Login temp_login { get; set; }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            LinkedList<Staff_Login> temp = Login_Functions.Create_Read_Account_Login_List();

            string[] Split_List_Item = new string[7];
            Split_List_Item[0] = Username_box.Text;
            Split_List_Item[1] = Password_box.Text;
            Split_List_Item[2] = firstname_box.Text;
            Split_List_Item[3] = Lastname_box.Text;
            Split_List_Item[4] = comboBox1.Text;
            Split_List_Item[5] = Salary_Box.Text;
            Split_List_Item[6] = Recovery_Email_box.Text;

            Staff_Login staff_Login = new Staff_Login();
            staff_Login.setUserName(Username_box.Text);
            staff_Login.setPassword(Password_box.Text);
            staff_Login.set_First_Name(firstname_box.Text);
            staff_Login.set_Last_Name(Lastname_box.Text);
            staff_Login.set_Role(comboBox1.Text);
            staff_Login.set_Salary(float.Parse(Salary_Box.Text));
            staff_Login.setRecovery(Recovery_Email_box.Text);
            temp.AddFirst(staff_Login);
            Login_Functions.Write_To_File(temp);


            ListViewItem items = new ListViewItem(Split_List_Item);
            listView_staff.Items.Add(items);

        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {
            if (listView_staff.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to modify this item", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    LinkedList<Staff_Login> temp = Login_Functions.Create_Read_Account_Login_List();
                    Staff_Login staff_Login = Login_Functions.Find_Item_by_selection_Return_Node(listView_staff.SelectedItems[0].SubItems[0].Text, temp);
                    temp.Remove(staff_Login);
                    staff_Login.setUserName(Username_box.Text);
                    staff_Login.setPassword(Password_box.Text);
                    staff_Login.set_First_Name(firstname_box.Text);
                    staff_Login.set_Last_Name(Lastname_box.Text);
                    staff_Login.set_Role(comboBox1.Text);
                    staff_Login.set_Salary(float.Parse(Salary_Box.Text));
                    staff_Login.setRecovery(Recovery_Email_box.Text);
                    temp.AddFirst(staff_Login);
                    
                    listView_staff.Items.Remove(listView_staff.SelectedItems[0]);
                    string[] Split_List_Item = new string[7];
                    Split_List_Item[0] = Username_box.Text;
                    Split_List_Item[1] = Password_box.Text;
                    Split_List_Item[2] = firstname_box.Text;
                    Split_List_Item[3] = Lastname_box.Text;
                    Split_List_Item[4] = comboBox1.Text;
                    Split_List_Item[5] = Salary_Box.Text;
                    Split_List_Item[6] = Recovery_Email_box.Text;

                    ListViewItem items = new ListViewItem(Split_List_Item);
                    listView_staff.Items.Add(items);


                    Login_Functions.Write_To_File(temp);
                }
            }
            else MessageBox.Show("Error when modify");
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (listView_staff.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to delete the item", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    LinkedList<Staff_Login> temp = Login_Functions.Create_Read_Account_Login_List();
                    StreamWriter strm = File.CreateText("Inventory.txt");
                    strm.Flush();
                    strm.Close();
                    Staff_Login temp_node = Login_Functions.Find_Item_by_selection_Return_Node(listView_staff.SelectedItems[0].SubItems[0].Text, temp);
                    bool test = temp.Remove(temp_node);
                    listView_staff.Items.Remove(listView_staff.SelectedItems[0]);

                    Login_Functions.Write_To_File(temp);
                }
            }
        }
        //==================================EnableTextBoxes()===============================

        
        
        private void Staff_List_Form_Load(object sender, EventArgs e)
        {
            LinkedList<Staff_Login> temp = Login_Functions.Create_Read_Account_Login_List();
            int number_of_item_in_file = temp.Count();
            comboBox1.Items.Add("");
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("Chef");
            comboBox1.Items.Add("Server");

            if (number_of_item_in_file > 0)
            {
                foreach(Staff_Login item in temp)
                {
                    string[] Split_List_Item = new string[7];
                    Split_List_Item[2] = item.get_First_Name();
                    Split_List_Item[3] = item.get_Last_Name();
                    Split_List_Item[0] = item.getUserName();
                    Split_List_Item[1] = item.getPassword();
                    Split_List_Item[4] = item.get_Role();
                    Split_List_Item[5] = item.get_Salary().ToString();
                    Split_List_Item[6] = item.getRecovery();
                    ListViewItem items = new ListViewItem(Split_List_Item);
                    listView_staff.Items.Add(items);
                }
            }
            else
            {
                string[] Split_List_Item = new string[7];
                Split_List_Item[0] = "Blank";
                Split_List_Item[1] = "Blank";
                Split_List_Item[2] = "Blank";
                Split_List_Item[3] = "Blank";
                Split_List_Item[4] = "Blank";
                Split_List_Item[5] = "Blank";
                Split_List_Item[6] = "Blank";
                ListViewItem items = new ListViewItem(Split_List_Item);
                listView_staff.Items.Add(items);
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

        private void Financial_btn_Click(object sender, EventArgs e)
        {

        }

        private void Staff_list_btn_Click(object sender, EventArgs e)
        {
            Staff_List_Form staff_List_Form = new Staff_List_Form();
            staff_List_Form.temp_login = temp_login;
            this.Hide();
            staff_List_Form.Show();
        }

        private void Salary_List_Btn_Click(object sender, EventArgs e)
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

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void About_btn_Click(object sender, EventArgs e)
        {

        }

        private void Help_btn_Click(object sender, EventArgs e)
        {

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
