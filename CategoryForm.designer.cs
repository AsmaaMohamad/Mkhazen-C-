namespace Makhazen
{
    partial class CategoryForm
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
            this.categoryData = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.sup_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryData
            // 
            this.categoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryData.Location = new System.Drawing.Point(12, 77);
            this.categoryData.Name = "categoryData";
            this.categoryData.Size = new System.Drawing.Size(435, 237);
            this.categoryData.TabIndex = 29;
            this.categoryData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryData_CellDoubleClick);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.show.Location = new System.Drawing.Point(198, 370);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(109, 45);
            this.show.TabIndex = 39;
            this.show.Text = "عرض";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.Show_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(47, 370);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 45);
            this.back.TabIndex = 38;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_btn.Location = new System.Drawing.Point(330, 366);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(117, 49);
            this.delete_btn.TabIndex = 37;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Peru;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_btn.Location = new System.Drawing.Point(468, 364);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(117, 51);
            this.update_btn.TabIndex = 36;
            this.update_btn.Text = "تعديل";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.insert_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insert_btn.Location = new System.Drawing.Point(631, 364);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(117, 51);
            this.insert_btn.TabIndex = 30;
            this.insert_btn.Text = "أضافة";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(453, 87);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(242, 31);
            this.idtxt.TabIndex = 31;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(713, 87);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(144, 29);
            this.id_lbl.TabIndex = 33;
            this.id_lbl.Text = "الرقم المتسلسل ";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(453, 144);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(242, 31);
            this.name_txt.TabIndex = 34;
            // 
            // sup_name
            // 
            this.sup_name.AutoSize = true;
            this.sup_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_name.Location = new System.Drawing.Point(713, 147);
            this.sup_name.Name = "sup_name";
            this.sup_name.Size = new System.Drawing.Size(63, 29);
            this.sup_name.TabIndex = 30;
            this.sup_name.Text = "الاسم ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "بيانات الاصناف ";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.sup_name);
            this.Controls.Add(this.categoryData);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryData;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label sup_name;
        private System.Windows.Forms.Label label2;
    }
}