namespace Makhazen
{
    partial class login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_frm));
            this.usr_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user_error = new System.Windows.Forms.Label();
            this.password_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usr_name
            // 
            this.usr_name.AutoSize = true;
            this.usr_name.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_name.Location = new System.Drawing.Point(690, 89);
            this.usr_name.Name = "usr_name";
            this.usr_name.Size = new System.Drawing.Size(74, 20);
            this.usr_name.TabIndex = 0;
            this.usr_name.Text = "اسم المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(430, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "تسجيل الدخول";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(391, 89);
            this.user_txt.Multiline = true;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(252, 35);
            this.user_txt.TabIndex = 2;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(391, 162);
            this.pass_txt.Multiline = true;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(252, 35);
            this.pass_txt.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(701, 163);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 17);
            this.password.TabIndex = 3;
            this.password.Text = "كلمة المرور";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Maroon;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(601, 282);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(140, 43);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "تسجيل";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(391, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "مستخدم جديد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // user_error
            // 
            this.user_error.AutoSize = true;
            this.user_error.Location = new System.Drawing.Point(473, 127);
            this.user_error.Name = "user_error";
            this.user_error.Size = new System.Drawing.Size(58, 13);
            this.user_error.TabIndex = 7;
            this.user_error.Text = "user_error";
            this.user_error.Visible = false;
            // 
            // password_error
            // 
            this.password_error.AutoSize = true;
            this.password_error.Location = new System.Drawing.Point(473, 215);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(83, 13);
            this.password_error.TabIndex = 8;
            this.password_error.Text = "password_error";
            this.password_error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_error);
            this.Controls.Add(this.user_error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usr_name);
            this.Name = "login_frm";
            this.Text = "تسجيل دخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usr_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user_error;
        private System.Windows.Forms.Label password_error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

