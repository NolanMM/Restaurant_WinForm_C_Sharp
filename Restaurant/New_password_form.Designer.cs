namespace Restaurant
{
    partial class New_password_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_password_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.newpass_box = new System.Windows.Forms.TextBox();
            this.New_password_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_text_box = new System.Windows.Forms.TextBox();
            this.Confirm_not_match = new System.Windows.Forms.Label();
            this.ErrorMessageSent = new System.Windows.Forms.Label();
            this.SuccessfullyMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(160, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter New Password";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Exit_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.Location = new System.Drawing.Point(954, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 45);
            this.Exit_btn.TabIndex = 11;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // newpass_box
            // 
            this.newpass_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.newpass_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpass_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_box.ForeColor = System.Drawing.Color.White;
            this.newpass_box.Location = new System.Drawing.Point(165, 197);
            this.newpass_box.Name = "newpass_box";
            this.newpass_box.Size = new System.Drawing.Size(265, 27);
            this.newpass_box.TabIndex = 15;
            // 
            // New_password_btn
            // 
            this.New_password_btn.BackColor = System.Drawing.Color.Black;
            this.New_password_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_password_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.New_password_btn.Location = new System.Drawing.Point(165, 396);
            this.New_password_btn.Name = "New_password_btn";
            this.New_password_btn.Size = new System.Drawing.Size(129, 36);
            this.New_password_btn.TabIndex = 16;
            this.New_password_btn.Text = "Enter";
            this.New_password_btn.UseVisualStyleBackColor = false;
            this.New_password_btn.Click += new System.EventHandler(this.New_password_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(160, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm New Password";
            // 
            // confirm_text_box
            // 
            this.confirm_text_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.confirm_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm_text_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_text_box.ForeColor = System.Drawing.Color.White;
            this.confirm_text_box.Location = new System.Drawing.Point(165, 312);
            this.confirm_text_box.Name = "confirm_text_box";
            this.confirm_text_box.Size = new System.Drawing.Size(265, 27);
            this.confirm_text_box.TabIndex = 18;
            // 
            // Confirm_not_match
            // 
            this.Confirm_not_match.BackColor = System.Drawing.Color.Transparent;
            this.Confirm_not_match.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm_not_match.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_not_match.ForeColor = System.Drawing.Color.Red;
            this.Confirm_not_match.Location = new System.Drawing.Point(161, 352);
            this.Confirm_not_match.Name = "Confirm_not_match";
            this.Confirm_not_match.Size = new System.Drawing.Size(343, 22);
            this.Confirm_not_match.TabIndex = 19;
            this.Confirm_not_match.Text = "The Password is not match. Please try again.";
            this.Confirm_not_match.Visible = false;
            // 
            // ErrorMessageSent
            // 
            this.ErrorMessageSent.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMessageSent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ErrorMessageSent.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageSent.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageSent.Location = new System.Drawing.Point(161, 352);
            this.ErrorMessageSent.Name = "ErrorMessageSent";
            this.ErrorMessageSent.Size = new System.Drawing.Size(343, 22);
            this.ErrorMessageSent.TabIndex = 20;
            this.ErrorMessageSent.Text = "Error When Re-write The New Information";
            this.ErrorMessageSent.Visible = false;
            // 
            // SuccessfullyMessage
            // 
            this.SuccessfullyMessage.BackColor = System.Drawing.Color.Transparent;
            this.SuccessfullyMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SuccessfullyMessage.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessfullyMessage.ForeColor = System.Drawing.Color.Red;
            this.SuccessfullyMessage.Location = new System.Drawing.Point(161, 352);
            this.SuccessfullyMessage.Name = "SuccessfullyMessage";
            this.SuccessfullyMessage.Size = new System.Drawing.Size(251, 22);
            this.SuccessfullyMessage.TabIndex = 21;
            this.SuccessfullyMessage.Text = "Change Password Successfully";
            this.SuccessfullyMessage.Visible = false;
            // 
            // New_password_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.SuccessfullyMessage);
            this.Controls.Add(this.ErrorMessageSent);
            this.Controls.Add(this.Confirm_not_match);
            this.Controls.Add(this.confirm_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.New_password_btn);
            this.Controls.Add(this.newpass_box);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_password_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_password_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit_btn;
        public System.Windows.Forms.TextBox newpass_box;
        public System.Windows.Forms.Button New_password_btn;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox confirm_text_box;
        public System.Windows.Forms.Label Confirm_not_match;
        public System.Windows.Forms.Label ErrorMessageSent;
        public System.Windows.Forms.Label SuccessfullyMessage;
    }
}