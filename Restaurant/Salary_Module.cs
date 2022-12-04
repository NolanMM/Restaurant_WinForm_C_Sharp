using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using static Restaurant.Inventory_Stub_Class;

namespace Restaurant
{
    public static class Salary_Functions
    {
        static public LinkedList<Salary_Staff> Read_The_Salary_From_File()
        {
            LinkedList<Salary_Staff> temp_List_In_Inventory = new LinkedList<Salary_Staff>();

            string filename = "Salary.txt";
            /* @ Loop through all the line in the file...................................*/
            var lines = File.ReadLines(filename);
            //string line_temp = "minhle-Minh-Nguyen-23.3-3-2-4-3-2-2-1";
            foreach (string line in lines)
            {
                string line_temp = line.ToString();
                Salary_Staff salary_node = new Salary_Staff();
                string[] Split_List_Item_Food = line.Split('-');

                /* Store information of the food into the node of the list of the food...*/
                salary_node.setUserName(Split_List_Item_Food[0]);
                salary_node.setFirstName(Split_List_Item_Food[1]);
                salary_node.setLastName(Split_List_Item_Food[2]);

                float Salary_per_Hour = (float)Convert.ToDouble(Split_List_Item_Food[3]);
                float Working_Hour_mon = (float)Convert.ToDouble(Split_List_Item_Food[4]);
                float Working_Hour_tue = (float)Convert.ToDouble(Split_List_Item_Food[5]);
                float Working_Hour_wed = (float)Convert.ToDouble(Split_List_Item_Food[6]);
                float Working_Hour_thur = (float)Convert.ToDouble(Split_List_Item_Food[7]);
                float Working_Hour_fri = (float)Convert.ToDouble(Split_List_Item_Food[8]);
                float Working_Hour_sat = (float)Convert.ToDouble(Split_List_Item_Food[9]);
                float Working_Hour_sun = (float)Convert.ToDouble(Split_List_Item_Food[10]);

                

                salary_node.set_Salary(Salary_per_Hour);
                salary_node.set_Working_Hour_mon(Working_Hour_mon);
                salary_node.set_Working_Hour_tue(Working_Hour_tue);
                salary_node.set_Working_Hour_wed(Working_Hour_wed);
                salary_node.set_Working_Hour_thur(Working_Hour_thur);
                salary_node.set_Working_Hour_fri(Working_Hour_fri);
                salary_node.set_Working_Hour_sat(Working_Hour_sat);
                salary_node.set_Working_Hour_sun(Working_Hour_sun);
                /* | Add the node to the list of the food in the fridge..................*/
                temp_List_In_Inventory.AddFirst(salary_node);

            }
            return temp_List_In_Inventory;
        }
        static public void Store_The_Salary_To_File(LinkedList<Salary_Staff> list_staff)
        {
            string filename = "Salary.txt";
            int counter = list_staff.Count();
            string[] salary_line = new string[counter];
            int i = 0;
            /* @ Loop thourgh all the list and write it into the file line by line */
            foreach (Salary_Staff item in list_staff)
            {
                /* @ The inventory_line layout is "Name_Of_Food-Portion_Number" */
                salary_line[i] = item.getUserName() + "-" + item.getFirstName() + "-" + item.getLastName() + "-"+ item.get_Salary().ToString() + "-" + item.get_Working_Hour_mon().ToString() + "-" + item.get_Working_Hour_tue().ToString() + "-" + item.get_Working_Hour_wed().ToString()
                    + "-" + item.get_Working_Hour_thur().ToString() + "-" + item.get_Working_Hour_fri().ToString() + "-" + item.get_Working_Hour_sat().ToString() + "-" + item.get_Working_Hour_sun().ToString();
                i++;
            }
            File.WriteAllLines(filename, salary_line);

        }
        static public Salary_Staff Checking_Specific_Satff_In_Salary(string username)
        {
            LinkedList<Salary_Staff> list_salary = Read_The_Salary_From_File();
            Salary_Staff find_item = new Salary_Staff();

            foreach (Salary_Staff salary in list_salary)
            {
                if (salary.getUserName() == username)
                {
                    find_item = salary;
                    break;
                }
            }
            return find_item;

        }
    }
}