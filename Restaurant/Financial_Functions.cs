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
        static public void StoreOrdersToFile(LinkedList<Financial_Restaurant> ordersList)
        {
            string filename = "RestaurantOrders.txt";
            if (File.Exists(filename))
            {
                /* Delete the file if it exsist to update new information whenever write to file again */
                File.Delete(filename);
                File.Create(filename);
            }
            else if (!File.Exists(filename)) { File.Create(filename); }

            /* @ Loop thourgh all the list and write it into the file line by line */
            foreach (Financial_Restaurant order in ordersList)
            {
                /* @ The inventory_line layout is "Name_Of_Food-Portion_Number" */
                string itemOfMenu_line = order.OrderNumber.ToString() + "-" + order.TotalCost.ToString() + "-" +
                    String.Join("|", order.ListOrderItems.ToArray()) + "-" + order.OrderDateAndTime.ToString();

                File.WriteAllText(filename, itemOfMenu_line);
            }
        }

        static public LinkedList<Financial_Restaurant> Read_The_Financial_From_File()
        {
            LinkedList<Financial_Restaurant> tempListOrders = new LinkedList<Financial_Restaurant>();

            string filename = "RestaurantOrders.txt";
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
                /* @ Loop through all the line in the file...................................*/
            string[] lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                Financial_Restaurant OrdersNode = new Financial_Restaurant();

                string[] SplitOrdersLine = line.Split('-');
                /* Store information of the food into the node of the list of the food...*/
                bool temp1;

                /* Store the order number of the order in the SplitOrdersLine[0] (int)....*/
                temp1 = int.TryParse(SplitOrdersLine[0], out int OrderNumber);
                if (temp1 == true)
                {
                    OrdersNode.OrderNumber = OrderNumber;
                }

                /* Store the total cost of the order in the SplitOrdersLine[1] (int).*/
                temp1 = int.TryParse(SplitOrdersLine[1], out int TotalCost);
                if (temp1 == true)
                {
                    OrdersNode.TotalCost = TotalCost;
                }

                /* Store the names of items of the order in the SplitOrdersLine[2] (strings)....*/
                string[] SplitItemsLine = SplitOrdersLine[2].Split('|');
                List<string> strings = new List<string>();
                foreach (string item in SplitItemsLine)
                {
                    strings.Add(item);
                }
                OrdersNode.ListOrderItems = strings;

                /* Store the date and time of the order in the SplitOrdersLine[3] (DateTime)....*/
                OrdersNode.OrderDateAndTime = SplitOrdersLine[3];

                /* | Add the node to the list of the orders..................*/
                tempListOrders.AddFirst(OrdersNode);
            }
            return tempListOrders;
        }

        private static string returnOrderAsString(Financial_Restaurant order)
        {
            string itemOfMenu_line;
            return itemOfMenu_line = "Order number: " + order.OrderNumber.ToString()
                + Environment.NewLine + "Total cost: " + order.TotalCost.ToString() + 
                Environment.NewLine + "Ordered items:" + 
                Environment.NewLine + String.Join(Environment.NewLine, order.ListOrderItems.ToArray()) + 
                Environment.NewLine + "Date and time: " + order.OrderDateAndTime.ToString() + "\n";
        }

        public static string ReturnAllOrdersAsString(LinkedList<Financial_Restaurant> OrderList)
        {
            string allOrders;
            allOrders = "--------------------" + Environment.NewLine;
            foreach (Financial_Restaurant order in OrderList)
            {
                allOrders += returnOrderAsString(order);
                allOrders += "--------------------" + Environment.NewLine;
            }

            return allOrders;
        }

        public static float ReturnTotalIncome(LinkedList<Financial_Restaurant> OrderList)
        {
            float totalIncome = 0;

            foreach(Financial_Restaurant order in OrderList)
            {
                totalIncome += order.TotalCost;
            }

            return totalIncome;
        }

        public static float ReturnIncomeForLastMonth(LinkedList<Financial_Restaurant> OrderList)
        {
            float incomeForMonth = 0;
            DateTime tempDate;

            foreach (Financial_Restaurant order in OrderList)
            {
                tempDate = DateTime.Parse(order.OrderDateAndTime);

                if (tempDate.Month == DateTime.Now.Month && tempDate.Year == DateTime.Now.Year)
                {
                    incomeForMonth += order.TotalCost;
                }
            }

            return incomeForMonth;
        }
    }
}