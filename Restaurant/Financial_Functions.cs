using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using static Restaurant.Financial_class;

namespace Restaurant
{
    public static class Financial_Functions
    {
        static public void Store_The_Salary_To_File(LinkedList<Financial_Restaurant> list_financial)
        {
            string filename = "FinacialFood.txt";
            int counter = list_financial.Count();
            int i = 0;
            string[] financial_line = new string[counter];
            /* @ Loop thourgh all the list and write it into the file line by line */
            foreach (Financial_Restaurant item in list_financial)
            {
                /* @ The inventory_line layout is "Name_Of_Food-Portion_Number" */
                financial_line[i] = item.get_NameFood() + "-" + item.get_NumberSell() + "-" + item.get_Prices();
                i++;
                
            }
            File.WriteAllLines(filename, financial_line);
        }
        static float Fiancial_Salary_All_Staff()
        {
            LinkedList<Salary_Staff> temp_salary_list_all = Salary_Functions.Read_The_Salary_From_File();
            float Total = 0;
            foreach (Salary_Staff temp_login in temp_salary_list_all)
            {

                float Total_Working = temp_login.get_Working_Hour_mon() + temp_login.get_Working_Hour_tue() + temp_login.get_Working_Hour_wed() + temp_login.get_Working_Hour_thur()
                    + temp_login.get_Working_Hour_fri() + temp_login.get_Working_Hour_sat() + temp_login.get_Working_Hour_sun();

                Total += Total_Working * temp_login.get_Salary();
            }
            return Total;
        }
        static public LinkedList<Financial_Restaurant> Read_The_Financial_From_File()
        {
            LinkedList<Financial_Restaurant> temp_List_In_Financial_Food = new LinkedList<Financial_Restaurant>();
            var lowerBound = 1000;
            var upperBound = 2500;

            /* @ Loop through all the line in the file...................................*/
            var lines = File.ReadLines("FinacialFood.txt");
            foreach (var line in lines)
            {
                var random = new Random();
                var rNum = random.Next(lowerBound, upperBound);

                Financial_Restaurant Financial_node = new Financial_Restaurant();
                /* Store the Name of the food in the Split_List_Item_Food[0] (String)....*/
                /* Store the Portion of the food in the Split_List_Item_Food[1] (String).*/
                string[] Split_List_Item_Food = line.Split('-');
                int Numbersell = Convert.ToInt32(Split_List_Item_Food[1]);
                float Prices = (float)Convert.ToDouble(Split_List_Item_Food[2]);
                float Prices_Electrics = (float)Convert.ToDouble(rNum);
                float Prices_Salary = (float)Convert.ToDouble(Fiancial_Salary_All_Staff());


                /* Store information of the food into the node of the list of the food...*/
                Financial_node.set_NameFood(Split_List_Item_Food[0]);
                Financial_node.set_NumberSell(Numbersell);
                Financial_node.set_Prices(Prices);

                Financial_node.set_Prices_Electrics(Prices_Electrics);
                Financial_node.set_Prices_Salary(Prices_Salary);
                temp_List_In_Financial_Food.AddFirst(Financial_node);

                /* | Add the node to the list of the food in the fridge..................*/

            }
            return temp_List_In_Financial_Food;
        }
    }
}