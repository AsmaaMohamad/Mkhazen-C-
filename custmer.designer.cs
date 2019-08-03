namespace Makhazen
{
    partial class custmerfrm
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
            this.customeraddress_lbl = new System.Windows.Forms.Label();
            this.customeraddrssText = new System.Windows.Forms.TextBox();
            this.custmeridText = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.Costomerphonelbl = new System.Windows.Forms.Label();
            this.customerphoneText = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.customr_namelbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.delete_customerbtn = new System.Windows.Forms.Button();
            this.update_customerbtn = new System.Windows.Forms.Button();
            this.customerinsert_btn = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.customerData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).BeginInit();
            this.SuspendLayout();
            // 
            // customeraddress_lbl
            // 
            this.customeraddress_lbl.AutoSize = true;
            this.customeraddress_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeraddress_lbl.ForeColor = System.Drawing.Color.Black;
            this.customeraddress_lbl.Location = new System.Drawing.Point(728, 249);
            this.customeraddress_lbl.Name = "customeraddress_lbl";
            this.customeraddress_lbl.Size = new System.Drawing.Size(67, 25);
            this.customeraddress_lbl.TabIndex = 21;
            this.customeraddress_lbl.Text = "العنوان";
            // 
            // customeraddrssText
            // 
            this.customeraddrssText.Location = new System.Drawing.Point(467, 231);
            this.customeraddrssText.Multiline = true;
            this.customeraddrssText.Name = "customeraddrssText";
            this.customeraddrssText.Size = new System.Drawing.Size(242, 43);
            this.customeraddrssText.TabIndex = 20;
            // 
            // custmeridText
            // 
            this.custmeridText.Enabled = false;
            this.custmeridText.Location = new System.Drawing.Point(467, 60);
            this.custmeridText.Multiline = true;
            this.custmeridText.Name = "custmeridText";
            this.custmeridText.Size = new System.Drawing.Size(242, 31);
            this.custmeridText.TabIndex = 19;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.Black;
            this.id_lbl.Location = new System.Drawing.Point(727, 78);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(137, 25);
            this.id_lbl.TabIndex = 18;
            this.id_lbl.Text = "الرقم المتسلسل ";
            // 
            // Costomerphonelbl
            // 
            this.Costomerphonelbl.AutoSize = true;
            this.Costomerphonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costomerphonelbl.ForeColor = System.Drawing.Color.Black;
            this.Costomerphonelbl.Location = new System.Drawing.Point(727, 188);
            this.Costomerphonelbl.Name = "Costomerphonelbl";
            this.Costomerphonelbl.Size = new System.Drawing.Size(111, 25);
            this.Costomerphonelbl.TabIndex = 17;
            this.Costomerphonelbl.Text = "رقم التليفون ";
            // 
            // customerphoneText
            // 
            this.customerphoneText.Location = new System.Drawing.Point(467, 170);
            this.customerphoneText.Multiline = true;
            this.customerphoneText.Name = "customerphoneText";
            this.customerphoneText.Size = new System.Drawing.Size(242, 31);
            this.customerphoneText.TabIndex = 16;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Chocolate;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(478, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(132, 29);
            this.data.TabIndex = 15;
            this.data.Text = "بيانات العميل ";
            // 
            // customerNameText
            // 
            this.customerNameText.Location = new System.Drawing.Point(467, 114);
            this.customerNameText.Multiline = true;
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(242, 31);
            this.customerNameText.TabIndex = 14;
            // 
            // customr_namelbl
            // 
            this.customr_namelbl.AutoSize = true;
            this.customr_namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customr_namelbl.ForeColor = System.Drawing.Color.Black;
            this.customr_namelbl.Location = new System.Drawing.Point(730, 132);
            this.customr_namelbl.Name = "customr_namelbl";
            this.customr_namelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customr_namelbl.Size = new System.Drawing.Size(59, 25);
            this.customr_namelbl.TabIndex = 13;
            this.customr_namelbl.Text = "الاسم ";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Orange;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(53, 298);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(117, 47);
            this.backbtn.TabIndex = 25;
            this.backbtn.Text = "رجوع";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // delete_customerbtn
            // 
            this.delete_customerbtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.delete_customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_customerbtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_customerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_customerbtn.Location = new System.Drawing.Point(333, 298);
            this.delete_customerbtn.Name = "delete_customerbtn";
            this.delete_customerbtn.Size = new System.Drawing.Size(117, 47);
            this.delete_customerbtn.TabIndex = 24;
            this.delete_customerbtn.Text = "حذف";
            this.delete_customerbtn.UseVisualStyleBackColor = false;
            this.delete_customerbtn.Click += new System.EventHandler(this.Delete_customerbtn_Click);
            // 
            // update_customerbtn
            // 
            this.update_customerbtn.BackColor = System.Drawing.Color.Peru;
            this.update_customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_customerbtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_customerbtn.ForeColor = System.Drawing.Color.White;
            this.update_customerbtn.Location = new System.Drawing.Point(503, 298);
            this.update_customerbtn.Name = "update_customerbtn";
            this.update_customerbtn.Size = new System.Drawing.Size(117, 47);
            this.update_customerbtn.TabIndex = 23;
            this.update_customerbtn.Text = "تعديل";
            this.update_customerbtn.UseVisualStyleBackColor = false;
            this.update_customerbtn.Click += new System.EventHandler(this.update_customerbtn_Click);
            // 
            // customerinsert_btn
            // 
            this.customerinsert_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.customerinsert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerinsert_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerinsert_btn.ForeColor = System.Drawing.Color.White;
            this.customerinsert_btn.Location = new System.Drawing.Point(676, 298);
            this.customerinsert_btn.Name = "customerinsert_btn";
            this.customerinsert_btn.Size = new System.Drawing.Size(117, 47);
            this.customerinsert_btn.TabIndex = 22;
            this.customerinsert_btn.Text = "أضافة";
            this.customerinsert_btn.UseVisualStyleBackColor = false;
            this.customerinsert_btn.Click += new System.EventHandler(this.Customerinsert_btn_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DarkBlue;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(200, 298);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(103, 47);
            this.show.TabIndex = 26;
            this.show.Text = "عرض";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.Show_Click);
            // 
            // customerData
            // 
            this.customerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerData.Location = new System.Drawing.Point(26, 45);
            this.customerData.Name = "customerData";
            this.customerData.Size = new System.Drawing.Size(435, 237);
            this.customerData.TabIndex = 27;
            this.customerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerData_CellContentClick);
            this.customerData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerData_CellDoubleClick);
            // 
            // custmerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 364);
            this.Controls.Add(this.customerData);
            this.Controls.Add(this.show);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.delete_customerbtn);
            this.Controls.Add(this.update_customerbtn);
            this.Controls.Add(this.customerinsert_btn);
            this.Controls.Add(this.customeraddress_lbl);
            this.Controls.Add(this.customeraddrssText);
            this.Controls.Add(this.custmeridText);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.Costomerphonelbl);
            this.Controls.Add(this.customerphoneText);
            this.Controls.Add(this.data);
            this.Controls.Add(this.customerNameText);
            this.Controls.Add(this.customr_namelbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "custmerfrm";
            this.Text = "العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customeraddress_lbl;
        private System.Windows.Forms.TextBox customeraddrssText;
        private System.Windows.Forms.TextBox custmeridText;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label Costomerphonelbl;
        private System.Windows.Forms.TextBox customerphoneText;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.Label customr_namelbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button delete_customerbtn;
        private System.Windows.Forms.Button update_customerbtn;
        private System.Windows.Forms.Button customerinsert_btn;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView customerData;
    }
}