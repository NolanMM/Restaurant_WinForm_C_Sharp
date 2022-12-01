using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Restaurant.Inventory_Stub_Class;

namespace Restaurant
{
    public static class Inventory_Functions
    {
        static public LinkedList<Inventory_Food> Read_The_Inventory_From_File()
        {
            LinkedList<Inventory_Food> temp_List_In_Inventory = new LinkedList<Inventory_Food>();
            Inventory_Food inventory_Food_node = new Inventory_Food();

            /* @ Loop through all the line in the file...................................*/
            var lines = File.ReadLines("Inventory.txt");
            foreach (var line in lines)
            {
                /* Store the Name of the food in the Split_List_Item_Food[0] (String)....*/
                /* Store the Portion of the food in the Split_List_Item_Food[1] (String).*/
                string[] Split_List_Item_Food = line.Split('-');

                /* Store information of the food into the node of the list of the food...*/
                inventory_Food_node.setNameFood(Split_List_Item_Food[0]);
                bool temp1 = int.TryParse(Split_List_Item_Food[1], out int Portions);
                if (temp1 == true)
                {
                    inventory_Food_node.setPortionFood(Portions);
                }
                /* | Add the node to the list of the food in the fridge..................*/
                temp_List_In_Inventory.AddFirst(inventory_Food_node);
            }
            return temp_List_In_Inventory;
        }
        static public Inventory_Food Node_From_List_by_name_of_Food_in_Inventory_List(string name,LinkedList<Inventory_Food> list_food)
        {
            Inventory_Food found_item = new Inventory_Food();
            foreach (Inventory_Food item in list_food)
            {
                /* @ Compare string with the  name of the food in the node in the list of the food items */
                if (name.CompareTo(item.getNameFood()) == 0)
                {
                    found_item = item;
                }
            }
            /* @ If found the item the variable found_item has value = item(node) */
            /* @ Else the found_item variable will be null                        */
            return found_item;
        }
        static public void Store_The_Inventory_To_File(LinkedList<Inventory_Food> list_food)
        {
            string filename = "Inventory.txt";

            /* @ Loop thourgh all the list and write it into the file line by line */
            foreach (Inventory_Food item in list_food)
            {
                /* @ The inventory_line layout is "Name_Of_Food-Portion_Number" */
                string inventory_line = item.getNameFood() + "-" + item.getPortionFood().ToString();
                File.WriteAllText(filename, inventory_line);
            }
        }
    }
}