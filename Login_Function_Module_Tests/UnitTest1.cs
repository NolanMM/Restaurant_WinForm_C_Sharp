using Restaurant;
using System.Data;
using static Restaurant.Inventory_Stub_Class;

namespace Restaurant_Integration_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LOGINMODULE_TC1()
        {
            // 
            string username = "minhle";
            string password = "minhle";
            string firstname = "minhle";
            string lastname = "minhle";
            string role = "minhle";
            float salary = 22.3f;
            string email_recovery = "minhle@gmail.com";

            string username_test = "minhle";
            string password_test = "minhle";
            bool return_value = false;
            Staff_Login temp_login = new Staff_Login();
            LinkedList<Staff_Login> list = new LinkedList<Staff_Login>();

            Staff_Login temp = new Staff_Login();
            bool checking = false;

            // Act
            // Assign value to Node in Staff_login list
            temp_login.setUserName(username_test);
            temp_login.setPassword(password_test);



            temp.setUserName(username);
            temp.setPassword(password);
            temp.set_First_Name(firstname);
            temp.set_Last_Name(lastname);
            temp.set_Role(role);
            temp.set_Salary(salary);
            temp.setRecovery(email_recovery);

            list.AddFirst(temp);

            
            // Call the function for checking the password and return bool ( True or False )

            checking = Login_Functions.Checking_Password_Test(list, temp_login);

            // Check if the password right or wrong, if {right} --> Interface in app for Staff,
            // else it will force the user to enter again

            if (checking == true)
            {
                return_value = Menu.Login_Menu_Stub_fortest();
            }
            else
            {
                return_value = false;
            }

            // Assert
            Assert.IsTrue(return_value); 
        }
        [TestMethod]
        [DeploymentItem("Login.txt", "C:\\Users\\Minh\\source\\repos\\Restaurant\\Restaurant\\bin\\Debug")]
        public void LOGINMODULE_TC2()
        {
            // Arrange
            Staff_Login temp_login = new Staff_Login();
            LinkedList<Staff_Login> list_Account = new LinkedList<Staff_Login>();
            string filename = "Login.txt";
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Login.txt");
            foreach (string line in lines)
            {
                Staff_Login temp_1 = new Staff_Login();
                string raw = Encrypted_Login.Decrypt(line);
                string[] Split_List_Item = raw.Split('-');

                string username = Split_List_Item[0];
                string password = Split_List_Item[1];
                string firstname = Split_List_Item[2];
                string lastname = Split_List_Item[3];
                string role = Split_List_Item[4];
                string salary = Split_List_Item[5];
                string email_recovery = Split_List_Item[6];

                temp_1.setUserName(username);
                temp_1.setPassword(password);
                temp_1.set_First_Name(firstname);
                temp_1.set_Last_Name(lastname);
                temp_1.set_Role(role);
                temp_1.set_Salary(Single.Parse(salary));
                temp_1.setRecovery(email_recovery);

                list_Account.AddFirst(temp_1);
            }


            string username_test = "minhle";
            string password_test = "minhle";


            Staff_Login temp = new Staff_Login();
            bool checking = false;

            // Act
            // Assign value to Node in Staff_login list
            if(username_test == list_Account.First.Value.getUserName() && password_test == list_Account.First.Value.getPassword())
            {
                checking = true;
            }
            else { checking = false;}

            // Assert
            Assert.IsTrue(checking);
        }

        [TestMethod]
        [DeploymentItem("Inventory.txt", "C:\\Users\\Minh\\source\\repos\\Restaurant\\Restaurant\\bin\\Debug")]
        public void INVENTORY_MENU_LIST_TEST_CASE_READ_FILE()
        {
            // Arrange
           
            LinkedList<Inventory_Food> temp_List_In_Inventory = new LinkedList<Inventory_Food>();
            Inventory_Food test = new Inventory_Food();
            /* @ Loop through all the line in the file...................................*/
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Inventory.txt");
            foreach (var line in lines)
            {
                /* Store the Name of the food in the Split_List_Item_Food[0] (String)....*/
                /* Store the Portion of the food in the Split_List_Item_Food[1] (String).*/
                string[] Split_List_Item_Food = line.Split('-');
                Inventory_Food inventory_Food_node = new Inventory_Food();
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
            

            string Name_food_expected = "Chicken";
            int portion_expected = 2;

            bool checking = false;

            // Act
            // Assign value to Node in Staff_login list
            test = temp_List_In_Inventory.First.Value;

            if (test.getNameFood() == Name_food_expected && test.getPortionFood() == portion_expected)
            {
                checking = true;
            }
            else { checking = false; }

            // Assert
            Assert.IsTrue(checking);
        }

        [TestMethod]
        [DeploymentItem("Inventory.txt", "C:\\Users\\Minh\\source\\repos\\Restaurant\\Restaurant\\bin\\Debug")]
        public void INVENTORY_MENU_LIST_TEST_CASE_WRITE_FILE()
        {
            // Arrange

            LinkedList<Inventory_Food> temp_List_In_Inventory = new LinkedList<Inventory_Food>();
            /* @ Loop through all the line in the file...................................*/
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Inventory.txt");
            foreach (var line in lines)
            {
                /* Store the Name of the food in the Split_List_Item_Food[0] (String)....*/
                /* Store the Portion of the food in the Split_List_Item_Food[1] (String).*/
                string[] Split_List_Item_Food = line.Split('-');
                Inventory_Food inventory_Food_node = new Inventory_Food();
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


            string Name_food_expected = "Goat";
            int portion_expected = 2;

            bool checking = false;

            // Act
            // Assign value to Node in Staff_login list
            temp_List_In_Inventory.First.Value.setNameFood(Name_food_expected);
            temp_List_In_Inventory.First.Value.setPortionFood(portion_expected);

            Inventory_Functions.Store_The_Inventory_To_File(temp_List_In_Inventory);

            LinkedList<Inventory_Food> List_In_Inventory = new LinkedList<Inventory_Food>();
            Inventory_Food test = new Inventory_Food();
            var lines_1 = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Inventory.txt");
            foreach (var line in lines_1)
            {
                /* Store the Name of the food in the Split_List_Item_Food[0] (String)....*/
                /* Store the Portion of the food in the Split_List_Item_Food[1] (String).*/
                string[] Split_List_Item_Food = line.Split('-');
                Inventory_Food inventory_Food_node = new Inventory_Food();
                /* Store information of the food into the node of the list of the food...*/
                inventory_Food_node.setNameFood(Split_List_Item_Food[0]);
                bool temp1 = int.TryParse(Split_List_Item_Food[1], out int Portions);
                if (temp1 == true)
                {
                    inventory_Food_node.setPortionFood(Portions);
                }
                /* | Add the node to the list of the food in the fridge..................*/
                List_In_Inventory.AddFirst(inventory_Food_node);
            }
            

            // Act
            // Assign value to Node in Staff_login list
            test = List_In_Inventory.First.Value;

            if (test.getNameFood() == Name_food_expected && test.getPortionFood() == portion_expected)
            {
                checking = true;
            }
            else { checking = false; }

            // Assert
            Assert.IsFalse(checking);
        }

        [TestMethod]
        [DeploymentItem("Salary.txt", "C:\\Users\\Minh\\source\\repos\\Restaurant\\Restaurant\\bin\\Debug")]
        public void SALARY_MODULE_READ_FROM_FILE_TEST_CASE()
        {
            // Arrange

            LinkedList<Salary_Staff> temp_List_In_Salary = new LinkedList<Salary_Staff>();
            Salary_Staff test = new Salary_Staff();
            /* @ Loop through all the line in the file...................................*/
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Salary.txt");
            foreach (var line in lines)
            {
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
                temp_List_In_Salary.AddFirst(salary_node);

            }


            string Username_Expected = "minhle";

            bool checking = false;

            // Act
            // Assign value to Node in Staff_login list
            test = temp_List_In_Salary.First.Value;

            if (test.getUserName() == Username_Expected)
            {
                checking = true;
            }
            else { checking = false; }

            // Assert
            Assert.IsTrue(checking);
        }

        [TestMethod]
        [DeploymentItem("Salary.txt", "C:\\Users\\Minh\\source\\repos\\Restaurant\\Restaurant\\bin\\Debug")]
        public void SALARY_MODULE_WRITE_FILE_TEST_CASE()
        {
            // Arrange

            LinkedList<Salary_Staff> temp_List_In_Salary = new LinkedList<Salary_Staff>();
            /* @ Loop through all the line in the file...................................*/
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Salary.txt");
            foreach (var line in lines)
            {
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
                temp_List_In_Salary.AddFirst(salary_node);

            }


            string Username_expected = "minhlenguyen";

            bool checking = false;

            // Act
            // Assign value to Node in Staff_login list
            temp_List_In_Salary.First.Value.setUserName(Username_expected);


            Salary_Functions.Store_The_Salary_To_File(temp_List_In_Salary);

            LinkedList<Salary_Staff> List_In_Inventory = new LinkedList<Salary_Staff>();
            Salary_Staff test = new Salary_Staff();

            var lines_temp = System.IO.File.ReadAllLines(@"C:\Users\Minh\source\repos\Restaurant\Restaurant\bin\Debug\Salary.txt");
            foreach (var line in lines_temp)
            {
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
                temp_List_In_Salary.AddFirst(salary_node);

            }


            // Act
            // Assign value to Node in Staff_login list
            test = temp_List_In_Salary.First.Value;

            if (test.getUserName() == Username_expected)
            {
                checking = true;
            }
            else { checking = false; }

            // Assert
            Assert.IsFalse(checking);
        }

    }
}