namespace Restaurant
{
    partial class Security_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Security_Form));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.About_btn = new System.Windows.Forms.Button();
            this.Help_btn = new System.Windows.Forms.Button();
            this.panelProfileSubmenu = new System.Windows.Forms.Panel();
            this.Change_password_btn = new System.Windows.Forms.Button();
            this.Timetable_btn = new System.Windows.Forms.Button();
            this.Salary_btn = new System.Windows.Forms.Button();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.panelRestaurantSubmenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Security_btn = new System.Windows.Forms.Button();
            this.Inventory_btn = new System.Windows.Forms.Button();
            this.Menu_food_btn = new System.Windows.Forms.Button();
            this.Restaurant_btn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Therminal = new System.Windows.Forms.Button();
            this.Humidity = new System.Windows.Forms.Button();
            this.Fan_Off = new System.Windows.Forms.Button();
            this.Fan_On = new System.Windows.Forms.Button();
            this.Led_Off = new System.Windows.Forms.Button();
            this.Led_On = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Open_btn = new System.Windows.Forms.Button();
            this.Temperature_box = new System.Windows.Forms.TextBox();
            this.Humidity_box = new System.Windows.Forms.TextBox();
            this.fan_box = new System.Windows.Forms.TextBox();
            this.Led_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Led_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COM_PORT_BOX = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelProfileSubmenu.SuspendLayout();
            this.panelRestaurantSubmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.Exit_btn);
            this.panelSideMenu.Controls.Add(this.About_btn);
            this.panelSideMenu.Controls.Add(this.Help_btn);
            this.panelSideMenu.Controls.Add(this.panelProfileSubmenu);
            this.panelSideMenu.Controls.Add(this.Profile_btn);
            this.panelSideMenu.Controls.Add(this.panelRestaurantSubmenu);
            this.panelSideMenu.Controls.Add(this.Restaurant_btn);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(218, 562);
            this.panelSideMenu.TabIndex = 3;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.DimGray;
            this.Exit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.Location = new System.Drawing.Point(0, 621);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Exit_btn.Size = new System.Drawing.Size(201, 40);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // About_btn
            // 
            this.About_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.About_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.About_btn.FlatAppearance.BorderSize = 0;
            this.About_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.About_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.About_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.About_btn.Location = new System.Drawing.Point(0, 581);
            this.About_btn.Name = "About_btn";
            this.About_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.About_btn.Size = new System.Drawing.Size(201, 40);
            this.About_btn.TabIndex = 5;
            this.About_btn.Text = "About";
            this.About_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_btn.UseVisualStyleBackColor = false;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // Help_btn
            // 
            this.Help_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Help_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_btn.FlatAppearance.BorderSize = 0;
            this.Help_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Help_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Help_btn.Location = new System.Drawing.Point(0, 541);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Help_btn.Size = new System.Drawing.Size(201, 40);
            this.Help_btn.TabIndex = 4;
            this.Help_btn.Text = "Help";
            this.Help_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_btn.UseVisualStyleBackColor = false;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // panelProfileSubmenu
            // 
            this.panelProfileSubmenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelProfileSubmenu.Controls.Add(this.Change_password_btn);
            this.panelProfileSubmenu.Controls.Add(this.Timetable_btn);
            this.panelProfileSubmenu.Controls.Add(this.Salary_btn);
            this.panelProfileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileSubmenu.Location = new System.Drawing.Point(0, 418);
            this.panelProfileSubmenu.Name = "panelProfileSubmenu";
            this.panelProfileSubmenu.Size = new System.Drawing.Size(201, 123);
            this.panelProfileSubmenu.TabIndex = 3;
            // 
            // Change_password_btn
            // 
            this.Change_password_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Change_password_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Change_password_btn.FlatAppearance.BorderSize = 0;
            this.Change_password_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Change_password_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Change_password_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_password_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Change_password_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Change_password_btn.Location = new System.Drawing.Point(0, 80);
            this.Change_password_btn.Name = "Change_password_btn";
            this.Change_password_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Change_password_btn.Size = new System.Drawing.Size(201, 43);
            this.Change_password_btn.TabIndex = 2;
            this.Change_password_btn.Text = "III. Change Password";
            this.Change_password_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change_password_btn.UseVisualStyleBackColor = false;
            this.Change_password_btn.Click += new System.EventHandler(this.Change_password_btn_Click);
            // 
            // Timetable_btn
            // 
            this.Timetable_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Timetable_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Timetable_btn.FlatAppearance.BorderSize = 0;
            this.Timetable_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Timetable_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Timetable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timetable_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Timetable_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Timetable_btn.Location = new System.Drawing.Point(0, 40);
            this.Timetable_btn.Name = "Timetable_btn";
            this.Timetable_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Timetable_btn.Size = new System.Drawing.Size(201, 40);
            this.Timetable_btn.TabIndex = 1;
            this.Timetable_btn.Text = "II. Timetable";
            this.Timetable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Timetable_btn.UseVisualStyleBackColor = false;
            // 
            // Salary_btn
            // 
            this.Salary_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Salary_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Salary_btn.FlatAppearance.BorderSize = 0;
            this.Salary_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salary_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Salary_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Salary_btn.Location = new System.Drawing.Point(0, 0);
            this.Salary_btn.Name = "Salary_btn";
            this.Salary_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Salary_btn.Size = new System.Drawing.Size(201, 40);
            this.Salary_btn.TabIndex = 0;
            this.Salary_btn.Text = "I.  Salary";
            this.Salary_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salary_btn.UseVisualStyleBackColor = false;
            this.Salary_btn.Click += new System.EventHandler(this.Salary_btn_Click);
            // 
            // Profile_btn
            // 
            this.Profile_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Profile_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile_btn.FlatAppearance.BorderSize = 0;
            this.Profile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Profile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Profile_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Profile_btn.Location = new System.Drawing.Point(0, 373);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Profile_btn.Size = new System.Drawing.Size(201, 45);
            this.Profile_btn.TabIndex = 2;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_btn.UseVisualStyleBackColor = false;
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // panelRestaurantSubmenu
            // 
            this.panelRestaurantSubmenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelRestaurantSubmenu.Controls.Add(this.button3);
            this.panelRestaurantSubmenu.Controls.Add(this.button2);
            this.panelRestaurantSubmenu.Controls.Add(this.button1);
            this.panelRestaurantSubmenu.Controls.Add(this.Security_btn);
            this.panelRestaurantSubmenu.Controls.Add(this.Inventory_btn);
            this.panelRestaurantSubmenu.Controls.Add(this.Menu_food_btn);
            this.panelRestaurantSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRestaurantSubmenu.Location = new System.Drawing.Point(0, 133);
            this.panelRestaurantSubmenu.Name = "panelRestaurantSubmenu";
            this.panelRestaurantSubmenu.Size = new System.Drawing.Size(201, 240);
            this.panelRestaurantSubmenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 200);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(201, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "VI. Salary List";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 160);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(201, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "V.  Staff List";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 120);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(201, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "IV. Financial";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Security_btn
            // 
            this.Security_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Security_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Security_btn.FlatAppearance.BorderSize = 0;
            this.Security_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Security_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Security_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Security_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Security_btn.Location = new System.Drawing.Point(0, 80);
            this.Security_btn.Name = "Security_btn";
            this.Security_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Security_btn.Size = new System.Drawing.Size(201, 40);
            this.Security_btn.TabIndex = 2;
            this.Security_btn.Text = "III. Security";
            this.Security_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Security_btn.UseVisualStyleBackColor = false;
            this.Security_btn.Click += new System.EventHandler(this.Security_btn_Click);
            // 
            // Inventory_btn
            // 
            this.Inventory_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Inventory_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inventory_btn.FlatAppearance.BorderSize = 0;
            this.Inventory_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Inventory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Inventory_btn.Location = new System.Drawing.Point(0, 40);
            this.Inventory_btn.Name = "Inventory_btn";
            this.Inventory_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Inventory_btn.Size = new System.Drawing.Size(201, 40);
            this.Inventory_btn.TabIndex = 1;
            this.Inventory_btn.Text = "II.  Inventory";
            this.Inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory_btn.UseVisualStyleBackColor = false;
            this.Inventory_btn.Click += new System.EventHandler(this.Inventory_btn_Click);
            // 
            // Menu_food_btn
            // 
            this.Menu_food_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Menu_food_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_food_btn.FlatAppearance.BorderSize = 0;
            this.Menu_food_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Menu_food_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Menu_food_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_food_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_food_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu_food_btn.Location = new System.Drawing.Point(0, 0);
            this.Menu_food_btn.Name = "Menu_food_btn";
            this.Menu_food_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Menu_food_btn.Size = new System.Drawing.Size(201, 40);
            this.Menu_food_btn.TabIndex = 0;
            this.Menu_food_btn.Text = "I.   Menu Food";
            this.Menu_food_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_food_btn.UseVisualStyleBackColor = false;
            this.Menu_food_btn.Click += new System.EventHandler(this.Menu_food_btn_Click);
            // 
            // Restaurant_btn
            // 
            this.Restaurant_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Restaurant_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Restaurant_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Restaurant_btn.FlatAppearance.BorderSize = 0;
            this.Restaurant_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Restaurant_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Restaurant_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restaurant_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurant_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Restaurant_btn.Location = new System.Drawing.Point(0, 88);
            this.Restaurant_btn.Name = "Restaurant_btn";
            this.Restaurant_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Restaurant_btn.Size = new System.Drawing.Size(201, 45);
            this.Restaurant_btn.TabIndex = 0;
            this.Restaurant_btn.Text = "Restaurant";
            this.Restaurant_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Restaurant_btn.UseVisualStyleBackColor = false;
            this.Restaurant_btn.Click += new System.EventHandler(this.Restaurant_btn_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(201, 88);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Therminal);
            this.panel1.Controls.Add(this.Humidity);
            this.panel1.Controls.Add(this.Fan_Off);
            this.panel1.Controls.Add(this.Fan_On);
            this.panel1.Controls.Add(this.Led_Off);
            this.panel1.Controls.Add(this.Led_On);
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Controls.Add(this.Open_btn);
            this.panel1.Controls.Add(this.Temperature_box);
            this.panel1.Controls.Add(this.Humidity_box);
            this.panel1.Controls.Add(this.fan_box);
            this.panel1.Controls.Add(this.Led_box);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Led_Status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.COM_PORT_BOX);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 562);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(408, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 43);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Connection Status";
            // 
            // Therminal
            // 
            this.Therminal.BackColor = System.Drawing.Color.Black;
            this.Therminal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Therminal.ForeColor = System.Drawing.Color.GreenYellow;
            this.Therminal.Location = new System.Drawing.Point(72, 475);
            this.Therminal.Name = "Therminal";
            this.Therminal.Size = new System.Drawing.Size(272, 45);
            this.Therminal.TabIndex = 31;
            this.Therminal.Text = "Temperature Update";
            this.Therminal.UseVisualStyleBackColor = false;
            this.Therminal.Click += new System.EventHandler(this.Therminal_Click_1);
            // 
            // Humidity
            // 
            this.Humidity.BackColor = System.Drawing.Color.Black;
            this.Humidity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.ForeColor = System.Drawing.Color.GreenYellow;
            this.Humidity.Location = new System.Drawing.Point(84, 361);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(244, 45);
            this.Humidity.TabIndex = 30;
            this.Humidity.Text = "Humidity Update";
            this.Humidity.UseVisualStyleBackColor = false;
            this.Humidity.Click += new System.EventHandler(this.Humidity_Click_1);
            // 
            // Fan_Off
            // 
            this.Fan_Off.BackColor = System.Drawing.Color.Black;
            this.Fan_Off.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fan_Off.ForeColor = System.Drawing.Color.Red;
            this.Fan_Off.Location = new System.Drawing.Point(268, 220);
            this.Fan_Off.Name = "Fan_Off";
            this.Fan_Off.Size = new System.Drawing.Size(122, 45);
            this.Fan_Off.TabIndex = 29;
            this.Fan_Off.Text = "Fan OFF";
            this.Fan_Off.UseVisualStyleBackColor = false;
            this.Fan_Off.Click += new System.EventHandler(this.Fan_Off_Click_1);
            // 
            // Fan_On
            // 
            this.Fan_On.BackColor = System.Drawing.Color.Black;
            this.Fan_On.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fan_On.ForeColor = System.Drawing.Color.Snow;
            this.Fan_On.Location = new System.Drawing.Point(34, 220);
            this.Fan_On.Name = "Fan_On";
            this.Fan_On.Size = new System.Drawing.Size(122, 45);
            this.Fan_On.TabIndex = 28;
            this.Fan_On.Text = "Fan ON";
            this.Fan_On.UseVisualStyleBackColor = false;
            this.Fan_On.Click += new System.EventHandler(this.Fan_On_Click_1);
            // 
            // Led_Off
            // 
            this.Led_Off.BackColor = System.Drawing.Color.Black;
            this.Led_Off.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Led_Off.ForeColor = System.Drawing.Color.Red;
            this.Led_Off.Location = new System.Drawing.Point(268, 121);
            this.Led_Off.Name = "Led_Off";
            this.Led_Off.Size = new System.Drawing.Size(122, 45);
            this.Led_Off.TabIndex = 27;
            this.Led_Off.Text = "Led OFF";
            this.Led_Off.UseVisualStyleBackColor = false;
            this.Led_Off.Click += new System.EventHandler(this.Led_Off_Click_1);
            // 
            // Led_On
            // 
            this.Led_On.BackColor = System.Drawing.Color.Black;
            this.Led_On.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Led_On.ForeColor = System.Drawing.Color.Snow;
            this.Led_On.Location = new System.Drawing.Point(34, 117);
            this.Led_On.Name = "Led_On";
            this.Led_On.Size = new System.Drawing.Size(122, 45);
            this.Led_On.TabIndex = 26;
            this.Led_On.Text = "Led ON";
            this.Led_On.UseVisualStyleBackColor = false;
            this.Led_On.Click += new System.EventHandler(this.Led_On_Click_1);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Black;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.Red;
            this.Close_btn.Location = new System.Drawing.Point(611, 235);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(87, 45);
            this.Close_btn.TabIndex = 25;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click_1);
            // 
            // Open_btn
            // 
            this.Open_btn.BackColor = System.Drawing.Color.Black;
            this.Open_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_btn.ForeColor = System.Drawing.Color.Snow;
            this.Open_btn.Location = new System.Drawing.Point(492, 235);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(89, 45);
            this.Open_btn.TabIndex = 24;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = false;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click_1);
            // 
            // Temperature_box
            // 
            this.Temperature_box.BackColor = System.Drawing.Color.Black;
            this.Temperature_box.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Temperature_box.ForeColor = System.Drawing.Color.White;
            this.Temperature_box.Location = new System.Drawing.Point(244, 430);
            this.Temperature_box.Name = "Temperature_box";
            this.Temperature_box.Size = new System.Drawing.Size(100, 43);
            this.Temperature_box.TabIndex = 23;
            // 
            // Humidity_box
            // 
            this.Humidity_box.BackColor = System.Drawing.Color.Black;
            this.Humidity_box.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Humidity_box.ForeColor = System.Drawing.Color.White;
            this.Humidity_box.Location = new System.Drawing.Point(214, 313);
            this.Humidity_box.Name = "Humidity_box";
            this.Humidity_box.Size = new System.Drawing.Size(114, 43);
            this.Humidity_box.TabIndex = 22;
            // 
            // fan_box
            // 
            this.fan_box.BackColor = System.Drawing.Color.Black;
            this.fan_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fan_box.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fan_box.ForeColor = System.Drawing.Color.Red;
            this.fan_box.Location = new System.Drawing.Point(162, 227);
            this.fan_box.Name = "fan_box";
            this.fan_box.Size = new System.Drawing.Size(100, 36);
            this.fan_box.TabIndex = 21;
            // 
            // Led_box
            // 
            this.Led_box.BackColor = System.Drawing.Color.Black;
            this.Led_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Led_box.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Led_box.ForeColor = System.Drawing.Color.Red;
            this.Led_box.Location = new System.Drawing.Point(162, 123);
            this.Led_box.Name = "Led_box";
            this.Led_box.Size = new System.Drawing.Size(100, 36);
            this.Led_box.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "FAN STATUS";
            // 
            // Led_Status
            // 
            this.Led_Status.AutoSize = true;
            this.Led_Status.BackColor = System.Drawing.Color.Transparent;
            this.Led_Status.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Led_Status.ForeColor = System.Drawing.Color.White;
            this.Led_Status.Location = new System.Drawing.Point(128, 75);
            this.Led_Status.Name = "Led_Status";
            this.Led_Status.Size = new System.Drawing.Size(159, 37);
            this.Led_Status.TabIndex = 16;
            this.Led_Status.Text = "Light Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "BAUD RATE";
            // 
            // COM_PORT_BOX
            // 
            this.COM_PORT_BOX.AutoSize = true;
            this.COM_PORT_BOX.BackColor = System.Drawing.Color.Transparent;
            this.COM_PORT_BOX.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.COM_PORT_BOX.ForeColor = System.Drawing.Color.White;
            this.COM_PORT_BOX.Location = new System.Drawing.Point(485, 75);
            this.COM_PORT_BOX.Name = "COM_PORT_BOX";
            this.COM_PORT_BOX.Size = new System.Drawing.Size(151, 37);
            this.COM_PORT_BOX.TabIndex = 12;
            this.COM_PORT_BOX.Text = "COM PORT";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Black;
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600"});
            this.comboBox2.Location = new System.Drawing.Point(492, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM3"});
            this.comboBox1.Location = new System.Drawing.Point(492, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Security_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Security_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security_Form";
            this.panelSideMenu.ResumeLayout(false);
            this.panelProfileSubmenu.ResumeLayout(false);
            this.panelRestaurantSubmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button About_btn;
        private System.Windows.Forms.Button Help_btn;
        private System.Windows.Forms.Panel panelProfileSubmenu;
        private System.Windows.Forms.Button Change_password_btn;
        private System.Windows.Forms.Button Timetable_btn;
        private System.Windows.Forms.Button Salary_btn;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Panel panelRestaurantSubmenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Security_btn;
        private System.Windows.Forms.Button Inventory_btn;
        private System.Windows.Forms.Button Menu_food_btn;
        private System.Windows.Forms.Button Restaurant_btn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Temperature_box;
        private System.Windows.Forms.TextBox Humidity_box;
        private System.Windows.Forms.TextBox fan_box;
        private System.Windows.Forms.TextBox Led_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Led_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label COM_PORT_BOX;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Button Close_btn;
        public System.Windows.Forms.Button Open_btn;
        public System.Windows.Forms.Button Therminal;
        public System.Windows.Forms.Button Humidity;
        public System.Windows.Forms.Button Fan_Off;
        public System.Windows.Forms.Button Fan_On;
        public System.Windows.Forms.Button Led_Off;
        public System.Windows.Forms.Button Led_On;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}