﻿namespace Restaurant
{
    partial class Forgot_Password_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Username_btn = new System.Windows.Forms.Button();
            this.Check_OTP_btn = new System.Windows.Forms.Button();
            this.username_box = new System.Windows.Forms.TextBox();
            this.OTP_box = new System.Windows.Forms.TextBox();
            this.incorrect_username = new System.Windows.Forms.Label();
            this.Too_many_Time_text = new System.Windows.Forms.Label();
            this.Wrong_Verify_code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(160, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(160, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "OTP Code";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.Location = new System.Drawing.Point(954, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 45);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Username_btn
            // 
            this.Username_btn.BackColor = System.Drawing.Color.Black;
            this.Username_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Username_btn.Location = new System.Drawing.Point(164, 255);
            this.Username_btn.Name = "Username_btn";
            this.Username_btn.Size = new System.Drawing.Size(129, 36);
            this.Username_btn.TabIndex = 12;
            this.Username_btn.Text = "Enter";
            this.Username_btn.UseVisualStyleBackColor = false;
            this.Username_btn.Click += new System.EventHandler(this.Username_btn_Click);
            // 
            // Check_OTP_btn
            // 
            this.Check_OTP_btn.BackColor = System.Drawing.Color.Black;
            this.Check_OTP_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_OTP_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Check_OTP_btn.Location = new System.Drawing.Point(164, 412);
            this.Check_OTP_btn.Name = "Check_OTP_btn";
            this.Check_OTP_btn.Size = new System.Drawing.Size(129, 37);
            this.Check_OTP_btn.TabIndex = 13;
            this.Check_OTP_btn.Text = "Enter";
            this.Check_OTP_btn.UseVisualStyleBackColor = false;
            this.Check_OTP_btn.Click += new System.EventHandler(this.Check_OTP_btn_Click);
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.ForeColor = System.Drawing.Color.White;
            this.username_box.Location = new System.Drawing.Point(165, 197);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(265, 27);
            this.username_box.TabIndex = 14;
            // 
            // OTP_box
            // 
            this.OTP_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.OTP_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OTP_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTP_box.ForeColor = System.Drawing.Color.White;
            this.OTP_box.Location = new System.Drawing.Point(164, 347);
            this.OTP_box.Name = "OTP_box";
            this.OTP_box.Size = new System.Drawing.Size(265, 27);
            this.OTP_box.TabIndex = 15;
            // 
            // incorrect_username
            // 
            this.incorrect_username.BackColor = System.Drawing.Color.Transparent;
            this.incorrect_username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incorrect_username.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrect_username.ForeColor = System.Drawing.Color.Red;
            this.incorrect_username.Location = new System.Drawing.Point(161, 230);
            this.incorrect_username.Name = "incorrect_username";
            this.incorrect_username.Size = new System.Drawing.Size(311, 22);
            this.incorrect_username.TabIndex = 16;
            this.incorrect_username.Text = "Cannot find Username, Please try again";
            this.incorrect_username.Visible = false;
            // 
            // Too_many_Time_text
            // 
            this.Too_many_Time_text.BackColor = System.Drawing.Color.Transparent;
            this.Too_many_Time_text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Too_many_Time_text.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Too_many_Time_text.ForeColor = System.Drawing.Color.Red;
            this.Too_many_Time_text.Location = new System.Drawing.Point(161, 377);
            this.Too_many_Time_text.Name = "Too_many_Time_text";
            this.Too_many_Time_text.Size = new System.Drawing.Size(452, 22);
            this.Too_many_Time_text.TabIndex = 17;
            this.Too_many_Time_text.Text = "You input wrong too many times. The Program Will Return...";
            this.Too_many_Time_text.Visible = false;
            // 
            // Wrong_Verify_code
            // 
            this.Wrong_Verify_code.BackColor = System.Drawing.Color.Transparent;
            this.Wrong_Verify_code.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Wrong_Verify_code.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong_Verify_code.ForeColor = System.Drawing.Color.Red;
            this.Wrong_Verify_code.Location = new System.Drawing.Point(161, 377);
            this.Wrong_Verify_code.Name = "Wrong_Verify_code";
            this.Wrong_Verify_code.Size = new System.Drawing.Size(255, 22);
            this.Wrong_Verify_code.TabIndex = 18;
            this.Wrong_Verify_code.Text = "Incorrect OTP.  Please try again";
            this.Wrong_Verify_code.Visible = false;
            // 
            // Forgot_Password_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 552);
            this.ControlBox = false;
            this.Controls.Add(this.Wrong_Verify_code);
            this.Controls.Add(this.Too_many_Time_text);
            this.Controls.Add(this.incorrect_username);
            this.Controls.Add(this.OTP_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.Check_OTP_btn);
            this.Controls.Add(this.Username_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forgot_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_Password_Form";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Username_btn;
        public System.Windows.Forms.Button Check_OTP_btn;
        public System.Windows.Forms.TextBox username_box;
        public System.Windows.Forms.TextBox OTP_box;
        public System.Windows.Forms.Label incorrect_username;
        public System.Windows.Forms.Label Too_many_Time_text;
        public System.Windows.Forms.Label Wrong_Verify_code;
    }
}