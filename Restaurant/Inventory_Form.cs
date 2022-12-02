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
using static Restaurant.Inventory_Stub_Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant
{
    public partial class Inventory_Form : Form
    {
        public Inventory_Form()
        {
            InitializeComponent();
            CustomizeDes();
        }
        public Staff_Login temp_login { get; set; }

        private void Inventory_Form_Load(object sender, EventArgs e)
        {
            
            LinkedList<Inventory_Food> temp = Inventory_Functions.Read_The_Inventory_From_File();

            int items =  temp.Count();

            foreach(Inventory_Food food in temp)
            {
                ListViewItem item = new ListViewItem();
                item.Text = food.getNameFood();
                listView_inventory.Items.Add(item);
                
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, food.getPortionFood().ToString());
                item.SubItems.Add(subItem);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            LinkedList<Inventory_Food> temp = Inventory_Functions.Read_The_Inventory_From_File();
            if ((string.IsNullOrEmpty(Name_Food_box.Text)) || (string.IsNullOrEmpty(Portion_box.Text)))
            {
                MessageBox.Show("Please Enter Full Information");
            }
            else
            {
                Inventory_Food food = new Inventory_Food();
                ListViewItem item = new ListViewItem();
                food.setNameFood(Name_Food_box.Text);
                item.Text = Name_Food_box.Text;
                listView_inventory.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (Portion_box.Text));
                food.setPortionFood(Convert.ToInt32(Portion_box.Text));
                item.SubItems.Add(subitem);
                temp.AddFirst(food);

                Inventory_Functions.Store_The_Inventory_To_File(temp);
                Name_Food_box.Clear();
                Portion_box.Clear();
                Name_Food_box.Focus();
            }
        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {
            if (listView_inventory.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to modify this item", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    LinkedList<Inventory_Food> temp = Inventory_Functions.Read_The_Inventory_From_File();
                    Inventory_Food temp_node = Inventory_Functions.Node_From_List_by_name_of_Food_in_Inventory_List(listView_inventory.SelectedItems[0].Text, temp);
                    temp.Remove(temp_node);
                    temp_node.setNameFood(Name_Food_box.Text);
                    temp_node.setPortionFood(Convert.ToInt32(Portion_box.Text));
                    temp.AddFirst(temp_node);
                    listView_inventory.Items.Remove(listView_inventory.SelectedItems[0]);

                    ListViewItem item = new ListViewItem();
                    item.Text = Name_Food_box.Text;
                    listView_inventory.Items.Add(item);

                    //listView_inventory.SelectedItems[0].Text = Name_Food_box.Text;
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (Portion_box.Text));
                    item.SubItems.Add(subitem);
                    Inventory_Functions.Store_The_Inventory_To_File(temp);
                    Name_Food_box.Clear();
                    Portion_box.Clear();
                    Name_Food_box.Focus();
                }
            }
            else MessageBox.Show("Error when modify");
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (listView_inventory.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to delete the item", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    LinkedList<Inventory_Food> temp = Inventory_Functions.Read_The_Inventory_From_File();
                    StreamWriter strm = File.CreateText("Inventory.txt");
                    strm.Flush();
                    strm.Close();
                    
                    Inventory_Food temp_node = Inventory_Functions.Node_From_List_by_name_of_Food_in_Inventory_List(listView_inventory.SelectedItems[0].Text,temp);
                    bool test = temp.Remove(temp_node);
                    temp.Remove(temp_node);
                    listView_inventory.Items.Remove(listView_inventory.SelectedItems[0]);
                    Inventory_Functions.Store_The_Inventory_To_File(temp);
                }
            }
            else MessageBox.Show("Error when delete");
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

        private void button3_Click(object sender, EventArgs e)
        {
            Financial financial_Form = new Financial();
            financial_Form.found_item = temp_login;
            this.Hide();
            financial_Form.Show();
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
