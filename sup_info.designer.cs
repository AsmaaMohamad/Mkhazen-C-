namespace Makhazen
{
    partial class sup_info
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
            this.sup_name = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.supplierData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.supplierData)).BeginInit();
            this.SuspendLayout();
            // 
            // sup_name
            // 
            this.sup_name.AutoSize = true;
            this.sup_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_name.Location = new System.Drawing.Point(713, 137);
            this.sup_name.Name = "sup_name";
            this.sup_name.Size = new System.Drawing.Size(66, 25);
            this.sup_name.TabIndex = 0;
            this.sup_name.Text = "الاسم  ";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(453, 134);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(242, 31);
            this.name_txt.TabIndex = 10;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Chocolate;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(685, 28);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(156, 29);
            this.data.TabIndex = 2;
            this.data.Text = "بيانات الموردين ";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.Location = new System.Drawing.Point(713, 199);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(111, 25);
            this.phonelbl.TabIndex = 8;
            this.phonelbl.Text = "رقم التليفون ";
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(453, 196);
            this.phonetxt.Multiline = true;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(242, 31);
            this.phonetxt.TabIndex = 7;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(453, 77);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(242, 31);
            this.idtxt.TabIndex = 1;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(713, 77);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(137, 25);
            this.id_lbl.TabIndex = 9;
            this.id_lbl.Text = "الرقم المتسلسل ";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(713, 264);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(67, 25);
            this.address_lbl.TabIndex = 12;
            this.address_lbl.Text = "العنوان";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(453, 261);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(242, 31);
            this.address_txt.TabIndex = 11;
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.insert_btn.Location = new System.Drawing.Point(710, 334);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(131, 48);
            this.insert_btn.TabIndex = 13;
            this.insert_btn.Text = "أضافة";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Peru;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.update_btn.Location = new System.Drawing.Point(529, 334);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(141, 48);
            this.update_btn.TabIndex = 14;
            this.update_btn.Text = "تعديل";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_btn.Location = new System.Drawing.Point(379, 334);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(126, 48);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(84, 334);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 48);
            this.back.TabIndex = 16;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.SystemColors.Control;
            this.show.Location = new System.Drawing.Point(240, 334);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(114, 50);
            this.show.TabIndex = 17;
            this.show.Text = "عرض";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.Show_Click);
            // 
            // supplierData
            // 
            this.supplierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierData.Location = new System.Drawing.Point(12, 68);
            this.supplierData.Name = "supplierData";
            this.supplierData.Size = new System.Drawing.Size(435, 237);
            this.supplierData.TabIndex = 28;
            this.supplierData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierData_CellDoubleClick);
            // 
            // sup_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 449);
            this.Controls.Add(this.supplierData);
            this.Controls.Add(this.show);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.data);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.sup_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "sup_info";
            this.Text = "sup_info";
            this.Load += new System.EventHandler(this.Sup_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label sup_name;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView supplierData;
    }
}