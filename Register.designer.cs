namespace Makhazen
{
    partial class Register
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
            this.Register_pass_txt = new System.Windows.Forms.TextBox();
            this.Register_user_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register_btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.usr_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_pass_txt
            // 
            this.Register_pass_txt.Location = new System.Drawing.Point(260, 190);
            this.Register_pass_txt.Multiline = true;
            this.Register_pass_txt.Name = "Register_pass_txt";
            this.Register_pass_txt.PasswordChar = '*';
            this.Register_pass_txt.Size = new System.Drawing.Size(252, 35);
            this.Register_pass_txt.TabIndex = 7;
            // 
            // Register_user_txt
            // 
            this.Register_user_txt.Location = new System.Drawing.Point(260, 117);
            this.Register_user_txt.Multiline = true;
            this.Register_user_txt.Name = "Register_user_txt";
            this.Register_user_txt.Size = new System.Drawing.Size(252, 35);
            this.Register_user_txt.TabIndex = 6;
            this.Register_user_txt.TextChanged += new System.EventHandler(this.Register_user_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(272, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "تسجيل مستخدم جديد";
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.Maroon;
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Register_btn.Location = new System.Drawing.Point(322, 248);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(140, 43);
            this.Register_btn.TabIndex = 8;
            this.Register_btn.Text = "تسجيل";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(562, 198);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 17);
            this.password.TabIndex = 10;
            this.password.Text = "كلمة المرور";
            // 
            // usr_name
            // 
            this.usr_name.AutoSize = true;
            this.usr_name.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_name.Location = new System.Drawing.Point(551, 124);
            this.usr_name.Name = "usr_name";
            this.usr_name.Size = new System.Drawing.Size(74, 20);
            this.usr_name.TabIndex = 9;
            this.usr_name.Text = "اسم المستخدم";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usr_name);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Register_pass_txt);
            this.Controls.Add(this.Register_user_txt);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Register_pass_txt;
        private System.Windows.Forms.TextBox Register_user_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label usr_name;
    }
}