using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public static class Financial_class
    {
        public class Financial_Restaurant
        {
            int orderNumber;
            int totalCost;
            List<string> orderItems;
            DateTime orderDateAndTime;     //To initialize: year -> month -> day -> hour -> minute -> second -> ms

            public Financial_Restaurant()
            { orderNumber = 0; totalCost = 0; orderItems = new List<string>(); orderDateAndTime = new DateTime(); }

            public int OrderNumber
            { get { return orderNumber; } set { orderNumber = value; } }

            public int TotalCost
            { get { return totalCost; } set { totalCost = value; } }

            public List<string> ListOrderItems
            { get { return orderItems; } set { orderItems = new List<string>(value); } }

            public string OrderDateAndTime
            { get { return orderDateAndTime.ToString(); } set { orderDateAndTime = DateTime.Parse(value); } }
        }
    }
}
