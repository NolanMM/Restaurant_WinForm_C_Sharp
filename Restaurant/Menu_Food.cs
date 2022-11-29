using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Menu_Food : Form
    {
        public Menu_Food()
        {
            InitializeComponent();
        }

        private void Restaurant_btn_Click(object sender, EventArgs e)
        {
            var frm = new Manager_Form();
            this.Hide();
            frm.Show();
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Manager_Form frm = new Manager_Form();
            this.Hide();
            frm.Show();
        }
    }
}
