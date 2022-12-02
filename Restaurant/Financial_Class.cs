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
            private string _Name;
            private float Prices;
            private int number_sell;
            private float Prices_Electrics;
            private float Prices_Salary;
            public void set_NameFood(string name) { _Name = name; }
            public string get_NameFood() { return _Name; }

            public void set_NumberSell(int portions) { number_sell = portions; }
            public int get_NumberSell() { return number_sell; }

            public void set_Prices(float prices) { Prices = prices; }
            public float get_Prices() { return Prices; }

            public void set_Prices_Electrics(float prices_Electrics) { Prices_Electrics = prices_Electrics; }
            public float get_Prices_Electrics() { return Prices_Electrics; }

            public void set_Prices_Salary(float prices_Salary) { Prices_Salary = prices_Salary; }
            public float get_Prices_Salary() { return Prices_Salary; }


        }
    }
}
