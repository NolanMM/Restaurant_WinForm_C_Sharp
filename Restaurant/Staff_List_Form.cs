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
    public partial class Staff_List_Form : Form
    {
        public Staff_List_Form()
        {
            InitializeComponent();
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            LinkedList<Staff_Login> temp = Login_Functions.Create_Read_Account_Login_List();

            string[] Split_List_Item = new string[7];
            Split_List_Item[0] = Username_box.Text;
            Split_List_Item[1] = Password_box.Text;
            Split_List_Item[2] = firstname_box.Text;
            Split_List_Item[3] = Lastname_box.Text;
            Split_List_Item[4] = comboBox1.Text;
            Split_List_Item[6] = Salary_Box.Text;
            Split_List_Item[5] = Recovery_Email_box.Text;

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
            if (listView_inventory.SelectedItems.Count > 0)
            {
            }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

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
                    Split_List_Item[0] = item.get_First_Name();
                    Split_List_Item[1] = item.get_Last_Name();
                    Split_List_Item[2] = item.getUserName();
                    Split_List_Item[3] = item.getPassword();
                    Split_List_Item[4] = item.get_Role();
                    Split_List_Item[6] = item.get_Salary().ToString();
                    Split_List_Item[5] = item.getRecovery();
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
    }
}
