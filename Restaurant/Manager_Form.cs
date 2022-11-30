using System.Windows.Forms;

namespace Restaurant
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
            CustomizeDes();
        }
        private void CustomizeDes()
        {
            panelRestaurantSubmenu.Visible = false;
            panelProfileSubmenu.Visible = false;
        }
        private void hideMenu()
        {
            if (panelRestaurantSubmenu.Visible == true)
                panelRestaurantSubmenu.Visible = false;
            if(panelProfileSubmenu.Visible == true)
                panelProfileSubmenu.Visible=false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }

        private void Restaurant_btn_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelRestaurantSubmenu);
        }
        private void Profile_btn_Click(object sender, System.EventArgs e)
        {
            showSubMenu(panelProfileSubmenu);
        }

        private void Menu_food_btn_Click(object sender, System.EventArgs e)
        { 
            Menu_Food temp = new Menu_Food();
            temp.Show();
            this.Hide();
        }


    }
}
