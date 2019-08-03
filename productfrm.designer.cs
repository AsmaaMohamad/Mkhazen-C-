namespace Makhazen
{
    partial class productfrm
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
            this.productname = new System.Windows.Forms.Label();
            this.prdctQuntity = new System.Windows.Forms.Label();
            this.prdctPrice = new System.Windows.Forms.Label();
            this.addPrdct = new System.Windows.Forms.Button();
            this.editPrdct = new System.Windows.Forms.Button();
            this.deletPrdct = new System.Windows.Forms.Button();
            this.prdctid = new System.Windows.Forms.TextBox();
            this.prdctqnt = new System.Windows.Forms.TextBox();
            this.prdctpric = new System.Windows.Forms.TextBox();
            this.prdctName = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.prodctGridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.categorycmbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.prdctpricetxt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodctGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(649, 85);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(99, 29);
            this.productname.TabIndex = 0;
            this.productname.Text = "اسم المنتج";
            this.productname.Click += new System.EventHandler(this.Productname_Click);
            // 
            // prdctQuntity
            // 
            this.prdctQuntity.AutoSize = true;
            this.prdctQuntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdctQuntity.Location = new System.Drawing.Point(675, 120);
            this.prdctQuntity.Name = "prdctQuntity";
            this.prdctQuntity.Size = new System.Drawing.Size(62, 29);
            this.prdctQuntity.TabIndex = 2;
            this.prdctQuntity.Text = "الكميه";
            this.prdctQuntity.Click += new System.EventHandler(this.PrdctQuntity_Click);
            // 
            // prdctPrice
            // 
            this.prdctPrice.AutoSize = true;
            this.prdctPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdctPrice.Location = new System.Drawing.Point(284, 50);
            this.prdctPrice.Name = "prdctPrice";
            this.prdctPrice.Size = new System.Drawing.Size(97, 24);
            this.prdctPrice.TabIndex = 3;
            this.prdctPrice.Text = "السعر الجملة";
            // 
            // addPrdct
            // 
            this.addPrdct.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPrdct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdct.ForeColor = System.Drawing.Color.White;
            this.addPrdct.Location = new System.Drawing.Point(608, 365);
            this.addPrdct.Name = "addPrdct";
            this.addPrdct.Size = new System.Drawing.Size(98, 53);
            this.addPrdct.TabIndex = 4;
            this.addPrdct.Text = "اضافة";
            this.addPrdct.UseVisualStyleBackColor = false;
            this.addPrdct.Click += new System.EventHandler(this.AddPrdct_Click);
            // 
            // editPrdct
            // 
            this.editPrdct.BackColor = System.Drawing.Color.Peru;
            this.editPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editPrdct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPrdct.ForeColor = System.Drawing.Color.White;
            this.editPrdct.Location = new System.Drawing.Point(490, 365);
            this.editPrdct.Name = "editPrdct";
            this.editPrdct.Size = new System.Drawing.Size(91, 53);
            this.editPrdct.TabIndex = 5;
            this.editPrdct.Text = "تعديل ";
            this.editPrdct.UseVisualStyleBackColor = false;
            this.editPrdct.Click += new System.EventHandler(this.EditPrdct_Click);
            // 
            // deletPrdct
            // 
            this.deletPrdct.BackColor = System.Drawing.Color.Red;
            this.deletPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletPrdct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletPrdct.ForeColor = System.Drawing.Color.White;
            this.deletPrdct.Location = new System.Drawing.Point(367, 368);
            this.deletPrdct.Name = "deletPrdct";
            this.deletPrdct.Size = new System.Drawing.Size(98, 50);
            this.deletPrdct.TabIndex = 6;
            this.deletPrdct.Text = "حذف ";
            this.deletPrdct.UseVisualStyleBackColor = false;
            this.deletPrdct.Click += new System.EventHandler(this.DeletPrdct_Click);
            // 
            // prdctid
            // 
            this.prdctid.Location = new System.Drawing.Point(398, 54);
            this.prdctid.Multiline = true;
            this.prdctid.Name = "prdctid";
            this.prdctid.ReadOnly = true;
            this.prdctid.Size = new System.Drawing.Size(214, 25);
            this.prdctid.TabIndex = 7;
            // 
            // prdctqnt
            // 
            this.prdctqnt.Location = new System.Drawing.Point(398, 124);
            this.prdctqnt.Multiline = true;
            this.prdctqnt.Name = "prdctqnt";
            this.prdctqnt.Size = new System.Drawing.Size(214, 27);
            this.prdctqnt.TabIndex = 9;
            this.prdctqnt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // prdctpric
            // 
            this.prdctpric.Location = new System.Drawing.Point(51, 50);
            this.prdctpric.Multiline = true;
            this.prdctpric.Name = "prdctpric";
            this.prdctpric.Size = new System.Drawing.Size(197, 29);
            this.prdctpric.TabIndex = 10;
            this.prdctpric.TextChanged += new System.EventHandler(this.Prdctpric_TextChanged);
            // 
            // prdctName
            // 
            this.prdctName.Location = new System.Drawing.Point(398, 85);
            this.prdctName.Multiline = true;
            this.prdctName.Name = "prdctName";
            this.prdctName.Size = new System.Drawing.Size(214, 29);
            this.prdctName.TabIndex = 8;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tomato;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(117, 370);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 50);
            this.back.TabIndex = 12;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(243, 370);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(84, 48);
            this.show.TabIndex = 13;
            this.show.Text = "عرض";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.Show_Click);
            // 
            // prodctGridData
            // 
            this.prodctGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodctGridData.Location = new System.Drawing.Point(51, 191);
            this.prodctGridData.Name = "prodctGridData";
            this.prodctGridData.Size = new System.Drawing.Size(686, 155);
            this.prodctGridData.TabIndex = 14;
            this.prodctGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdctGridData_CellContentClick);
            this.prodctGridData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdctGridData_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "الصنف";
            // 
            // categorycmbo
            // 
            this.categorycmbo.FormattingEnabled = true;
            this.categorycmbo.Location = new System.Drawing.Point(51, 130);
            this.categorycmbo.Name = "categorycmbo";
            this.categorycmbo.Size = new System.Drawing.Size(197, 21);
            this.categorycmbo.TabIndex = 16;
            this.categorycmbo.SelectedIndexChanged += new System.EventHandler(this.categorycmbo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "بيانات المنتجات ";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(617, 54);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(137, 25);
            this.id_lbl.TabIndex = 19;
            this.id_lbl.Text = "الرقم المتسلسل ";
            // 
            // prdctpricetxt2
            // 
            this.prdctpricetxt2.Location = new System.Drawing.Point(51, 89);
            this.prdctpricetxt2.Multiline = true;
            this.prdctpricetxt2.Name = "prdctpricetxt2";
            this.prdctpricetxt2.Size = new System.Drawing.Size(197, 29);
            this.prdctpricetxt2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "السعر القاطعي";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "تاريخ انتهاء الصلاحية";
            // 
            // productfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.prdctpricetxt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categorycmbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodctGridData);
            this.Controls.Add(this.show);
            this.Controls.Add(this.back);
            this.Controls.Add(this.prdctName);
            this.Controls.Add(this.prdctpric);
            this.Controls.Add(this.prdctqnt);
            this.Controls.Add(this.prdctid);
            this.Controls.Add(this.deletPrdct);
            this.Controls.Add(this.editPrdct);
            this.Controls.Add(this.addPrdct);
            this.Controls.Add(this.prdctPrice);
            this.Controls.Add(this.prdctQuntity);
            this.Controls.Add(this.productname);
            this.Name = "productfrm";
            this.Text = "المنتجات";
            this.Load += new System.EventHandler(this.productfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodctGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prdctid;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.Label prdctQuntity;
        private System.Windows.Forms.Label prdctPrice;
        private System.Windows.Forms.Button addPrdct;
        private System.Windows.Forms.Button editPrdct;
        private System.Windows.Forms.Button deletPrdct;
        private System.Windows.Forms.TextBox prdctqnt;
        private System.Windows.Forms.TextBox prdctpric;
        private System.Windows.Forms.TextBox prdctName;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView prodctGridData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categorycmbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox prdctpricetxt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}

