namespace Restaurant
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.username_input = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.forgot_password_btn = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.incorrect_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_input
            // 
            this.username_input.AutoSize = true;
            this.username_input.BackColor = System.Drawing.Color.Transparent;
            this.username_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_input.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.ForeColor = System.Drawing.Color.SlateBlue;
            this.username_input.Location = new System.Drawing.Point(40, 185);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(146, 35);
            this.username_input.TabIndex = 1;
            this.username_input.Text = "Username";
            // 
            // password_input
            // 
            this.password_input.AutoSize = true;
            this.password_input.BackColor = System.Drawing.Color.Transparent;
            this.password_input.Font = new System.Drawing.Font("Forte", 24F);
            this.password_input.ForeColor = System.Drawing.Color.SlateBlue;
            this.password_input.Location = new System.Drawing.Point(39, 255);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(147, 35);
            this.password_input.TabIndex = 1;
            this.password_input.Text = "Password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To Space Restaurant";
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_box.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.ForeColor = System.Drawing.Color.White;
            this.username_box.Location = new System.Drawing.Point(223, 185);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(265, 27);
            this.username_box.TabIndex = 3;
            // 
            // forgot_password_btn
            // 
            this.forgot_password_btn.BackColor = System.Drawing.Color.Transparent;
            this.forgot_password_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgot_password_btn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_btn.ForeColor = System.Drawing.Color.Maroon;
            this.forgot_password_btn.Location = new System.Drawing.Point(220, 295);
            this.forgot_password_btn.Name = "forgot_password_btn";
            this.forgot_password_btn.Size = new System.Drawing.Size(142, 28);
            this.forgot_password_btn.TabIndex = 5;
            this.forgot_password_btn.Text = "Forgot Password";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Black;
            this.Login_btn.Font = new System.Drawing.Font("Forte", 24F);
            this.Login_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Login_btn.Location = new System.Drawing.Point(223, 370);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(202, 45);
            this.Login_btn.TabIndex = 6;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(223, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 27);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(12, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // incorrect_message
            // 
            this.incorrect_message.BackColor = System.Drawing.Color.Transparent;
            this.incorrect_message.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incorrect_message.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrect_message.ForeColor = System.Drawing.Color.Red;
            this.incorrect_message.Location = new System.Drawing.Point(221, 215);
            this.incorrect_message.Name = "incorrect_message";
            this.incorrect_message.Size = new System.Drawing.Size(386, 22);
            this.incorrect_message.TabIndex = 10;
            this.incorrect_message.Text = "Incorrect Password or Username. Please try again";
            this.incorrect_message.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 601);
            this.ControlBox = false;
            this.Controls.Add(this.incorrect_message);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.forgot_password_btn);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Manager System";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username_input;
        private System.Windows.Forms.Label password_input;
        public System.Windows.Forms.Label forgot_password_btn;
        public System.Windows.Forms.TextBox username_box;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button Login_btn;
        public System.Windows.Forms.Label incorrect_message;
    }
}

