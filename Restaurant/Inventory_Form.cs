﻿using System;
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
        }

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
    }
}
