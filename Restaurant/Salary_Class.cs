using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Salary_Staff
    {
        private string _username;
        private float Salary;

        private float Working_Hour_Mon;
        private float Working_Hour_Tue;
        private float Working_Hour_Wed;
        private float Working_Hour_Thur;
        private float Working_Hour_Fri;
        private float Working_Hour_Sat;
        private float Working_Hour_Sun;
        public void setUserName(string Username) { _username = Username; }
        public string getUserName() { return _username; }
        public void set_Salary(float salary) { Salary = salary; }
        public float get_Salary() { return Salary; }
        public void set_Working_Hour_mon(float working_Hour) { Working_Hour_Mon = working_Hour; }
        public float get_Working_Hour_mon() { return Working_Hour_Mon; }

        public void set_Working_Hour_tue(float working_Hour) { Working_Hour_Tue = working_Hour; }
        public float get_Working_Hour_tue() { return Working_Hour_Tue; }

        public void set_Working_Hour_wed(float working_Hour) { Working_Hour_Wed = working_Hour; }
        public float get_Working_Hour_wed() { return Working_Hour_Wed; }

        public void set_Working_Hour_thur(float working_Hour) { Working_Hour_Thur = working_Hour; }
        public float get_Working_Hour_thur() { return Working_Hour_Thur; }

        public void set_Working_Hour_fri(float working_Hour) { Working_Hour_Fri = working_Hour; }
        public float get_Working_Hour_fri() { return Working_Hour_Fri; }

        public void set_Working_Hour_sat(float working_Hour) { Working_Hour_Sat = working_Hour; }
        public float get_Working_Hour_sat() { return Working_Hour_Sat; }

        public void set_Working_Hour_sun(float working_Hour) { Working_Hour_Sun = working_Hour; }
        public float get_Working_Hour_sun() { return Working_Hour_Sun; }
    }
}
