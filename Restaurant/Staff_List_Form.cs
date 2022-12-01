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

        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void Staff_List_Form_Load(object sender, EventArgs e)
        {
            LinkedList<Staff_Login> temp = Login_Functions.Create_Read_Account_Login_List();
            int number_of_item_in_file = temp.Count();
            if (number_of_item_in_file < 0)
            {
                foreach(Staff_Login item in temp)
                {
                    string[] Split_List_Item = new string[7];
                    Split_List_Item[0] = item.get_First_Name();
                    Split_List_Item[1] = item.get_Last_Name();
                    Split_List_Item[2] = item.getUserName();
                    Split_List_Item[3] = item.getPassword();
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
    }
}
