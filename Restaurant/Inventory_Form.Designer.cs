﻿namespace Restaurant
{
    partial class Inventory_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Form));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Security_btn = new System.Windows.Forms.Button();
            this.Inventory_btn = new System.Windows.Forms.Button();
            this.Menu_food_btn = new System.Windows.Forms.Button();
            this.Restaurant_btn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Modify_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Portion_box = new System.Windows.Forms.TextBox();
            this.Name_Food_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_inventory = new System.Windows.Forms.ListView();
            this.Name_of_Food = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Portion_Left = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelProfileSubmenu.SuspendLayout();
            this.panelRestaurantSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelSideMenu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Modify_btn);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Controls.Add(this.Portion_box);
            this.panel1.Controls.Add(this.Name_Food_box);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView_inventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 553);
            this.panel1.TabIndex = 4;
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
            this.panelSideMenu.Size = new System.Drawing.Size(218, 553);
            this.panelSideMenu.TabIndex = 15;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.DimGray;
            this.Exit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.Location = new System.Drawing.Point(0, 553);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Exit_btn.Size = new System.Drawing.Size(201, 51);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_btn.UseVisualStyleBackColor = false;
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
            this.About_btn.Location = new System.Drawing.Point(0, 508);
            this.About_btn.Name = "About_btn";
            this.About_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.About_btn.Size = new System.Drawing.Size(201, 45);
            this.About_btn.TabIndex = 5;
            this.About_btn.Text = "About";
            this.About_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_btn.UseVisualStyleBackColor = false;
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
            this.Help_btn.Location = new System.Drawing.Point(0, 463);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Help_btn.Size = new System.Drawing.Size(201, 45);
            this.Help_btn.TabIndex = 4;
            this.Help_btn.Text = "Help";
            this.Help_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_btn.UseVisualStyleBackColor = false;
            // 
            // panelProfileSubmenu
            // 
            this.panelProfileSubmenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelProfileSubmenu.Controls.Add(this.Change_password_btn);
            this.panelProfileSubmenu.Controls.Add(this.Timetable_btn);
            this.panelProfileSubmenu.Controls.Add(this.Salary_btn);
            this.panelProfileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileSubmenu.Location = new System.Drawing.Point(0, 337);
            this.panelProfileSubmenu.Name = "panelProfileSubmenu";
            this.panelProfileSubmenu.Size = new System.Drawing.Size(201, 126);
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
            this.Change_password_btn.Size = new System.Drawing.Size(201, 46);
            this.Change_password_btn.TabIndex = 2;
            this.Change_password_btn.Text = "III. Change Password";
            this.Change_password_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change_password_btn.UseVisualStyleBackColor = false;
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
            this.Profile_btn.Location = new System.Drawing.Point(0, 292);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Profile_btn.Size = new System.Drawing.Size(201, 45);
            this.Profile_btn.TabIndex = 2;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_btn.UseVisualStyleBackColor = false;
            // 
            // panelRestaurantSubmenu
            // 
            this.panelRestaurantSubmenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelRestaurantSubmenu.Controls.Add(this.button3);
            this.panelRestaurantSubmenu.Controls.Add(this.Security_btn);
            this.panelRestaurantSubmenu.Controls.Add(this.Inventory_btn);
            this.panelRestaurantSubmenu.Controls.Add(this.Menu_food_btn);
            this.panelRestaurantSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRestaurantSubmenu.Location = new System.Drawing.Point(0, 133);
            this.panelRestaurantSubmenu.Name = "panelRestaurantSubmenu";
            this.panelRestaurantSubmenu.Size = new System.Drawing.Size(201, 159);
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
            this.button3.Location = new System.Drawing.Point(0, 120);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(201, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "IV. Financial";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(446, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 72);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inventory List";
            // 
            // Modify_btn
            // 
            this.Modify_btn.BackColor = System.Drawing.Color.Black;
            this.Modify_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_btn.ForeColor = System.Drawing.Color.Snow;
            this.Modify_btn.Location = new System.Drawing.Point(554, 414);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(135, 45);
            this.Modify_btn.TabIndex = 11;
            this.Modify_btn.Text = "Modify";
            this.Modify_btn.UseVisualStyleBackColor = false;
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Black;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.Delete_btn.Location = new System.Drawing.Point(837, 418);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(135, 45);
            this.Delete_btn.TabIndex = 10;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Black;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.Snow;
            this.Add_btn.Location = new System.Drawing.Point(274, 418);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(135, 45);
            this.Add_btn.TabIndex = 9;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Portion_box
            // 
            this.Portion_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.Portion_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Portion_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Portion_box.ForeColor = System.Drawing.Color.White;
            this.Portion_box.Location = new System.Drawing.Point(707, 273);
            this.Portion_box.Name = "Portion_box";
            this.Portion_box.Size = new System.Drawing.Size(265, 27);
            this.Portion_box.TabIndex = 8;
            // 
            // Name_Food_box
            // 
            this.Name_Food_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.Name_Food_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Food_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Food_box.ForeColor = System.Drawing.Color.White;
            this.Name_Food_box.Location = new System.Drawing.Point(707, 201);
            this.Name_Food_box.Name = "Name_Food_box";
            this.Name_Food_box.Size = new System.Drawing.Size(265, 27);
            this.Name_Food_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(702, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Portion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(702, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(700, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modify Inventory List";
            // 
            // listView_inventory
            // 
            this.listView_inventory.BackColor = System.Drawing.Color.Black;
            this.listView_inventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_inventory.BackgroundImage")));
            this.listView_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_of_Food,
            this.Portion_Left});
            this.listView_inventory.ForeColor = System.Drawing.Color.White;
            this.listView_inventory.GridLines = true;
            this.listView_inventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_inventory.HideSelection = false;
            this.listView_inventory.Location = new System.Drawing.Point(274, 111);
            this.listView_inventory.MultiSelect = false;
            this.listView_inventory.Name = "listView_inventory";
            this.listView_inventory.Size = new System.Drawing.Size(363, 226);
            this.listView_inventory.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_inventory.TabIndex = 0;
            this.listView_inventory.UseCompatibleStateImageBehavior = false;
            this.listView_inventory.View = System.Windows.Forms.View.Details;
            // 
            // Name_of_Food
            // 
            this.Name_of_Food.Text = "Name of the Food";
            this.Name_of_Food.Width = 240;
            // 
            // Portion_Left
            // 
            this.Portion_Left.Text = "Portion left";
            this.Portion_Left.Width = 120;
            // 
            // Inventory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_Form";
            this.Load += new System.EventHandler(this.Inventory_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelProfileSubmenu.ResumeLayout(false);
            this.panelRestaurantSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_inventory;
        private System.Windows.Forms.ColumnHeader Name_of_Food;
        private System.Windows.Forms.ColumnHeader Portion_Left;
        public System.Windows.Forms.TextBox Portion_box;
        public System.Windows.Forms.TextBox Name_Food_box;
        public System.Windows.Forms.Button Modify_btn;
        public System.Windows.Forms.Button Delete_btn;
        public System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Button Security_btn;
        private System.Windows.Forms.Button Inventory_btn;
        private System.Windows.Forms.Button Menu_food_btn;
        private System.Windows.Forms.Button Restaurant_btn;
        private System.Windows.Forms.Panel panelLogo;
    }
}