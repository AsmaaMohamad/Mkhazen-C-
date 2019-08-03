namespace Makhazen
{
    partial class receipt_to_suppliers
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
            this.paid_textbox = new System.Windows.Forms.TextBox();
            this.remin_lable = new System.Windows.Forms.Label();
            this.sup_cmbo = new System.Windows.Forms.ComboBox();
            this.billNum = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.remainderlbl = new System.Windows.Forms.Label();
            this.paidlbl = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.customeridlbl = new System.Windows.Forms.Label();
            this.bill_date = new System.Windows.Forms.DateTimePicker();
            this.datlbl = new System.Windows.Forms.Label();
            this.catlbl = new System.Windows.Forms.Label();
            this.productcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.product_lbl = new System.Windows.Forms.Label();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.catcmbo = new System.Windows.Forms.ComboBox();
            this.add_prdct = new System.Windows.Forms.Button();
            this.prduct_GridView1 = new System.Windows.Forms.DataGridView();
            this.price_lable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retrialPrice_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.whalePrice_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.reminLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prduct_GridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paid_textbox
            // 
            this.paid_textbox.Location = new System.Drawing.Point(142, 63);
            this.paid_textbox.Multiline = true;
            this.paid_textbox.Name = "paid_textbox";
            this.paid_textbox.Size = new System.Drawing.Size(139, 31);
            this.paid_textbox.TabIndex = 74;
            this.paid_textbox.TextChanged += new System.EventHandler(this.Paid_textbox_TextChanged);
            // 
            // remin_lable
            // 
            this.remin_lable.AutoSize = true;
            this.remin_lable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remin_lable.Location = new System.Drawing.Point(20, 63);
            this.remin_lable.Name = "remin_lable";
            this.remin_lable.Size = new System.Drawing.Size(0, 23);
            this.remin_lable.TabIndex = 75;
            this.remin_lable.Click += new System.EventHandler(this.remin_lable_Click);
            // 
            // sup_cmbo
            // 
            this.sup_cmbo.FormattingEnabled = true;
            this.sup_cmbo.Location = new System.Drawing.Point(506, 100);
            this.sup_cmbo.Name = "sup_cmbo";
            this.sup_cmbo.Size = new System.Drawing.Size(242, 21);
            this.sup_cmbo.TabIndex = 72;
            // 
            // billNum
            // 
            this.billNum.Location = new System.Drawing.Point(510, 55);
            this.billNum.Multiline = true;
            this.billNum.Name = "billNum";
            this.billNum.Size = new System.Drawing.Size(242, 25);
            this.billNum.TabIndex = 68;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(768, 55);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(112, 25);
            this.id_lbl.TabIndex = 67;
            this.id_lbl.Text = "رقم الفاتورة ";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Tomato;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backbtn.Location = new System.Drawing.Point(613, 457);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(98, 38);
            this.backbtn.TabIndex = 66;
            this.backbtn.Text = "رجوع";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.White;
            this.insert_btn.Location = new System.Drawing.Point(721, 457);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(98, 38);
            this.insert_btn.TabIndex = 64;
            this.insert_btn.Text = "أضافة";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // remainderlbl
            // 
            this.remainderlbl.AutoSize = true;
            this.remainderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainderlbl.Location = new System.Drawing.Point(69, 61);
            this.remainderlbl.Name = "remainderlbl";
            this.remainderlbl.Size = new System.Drawing.Size(63, 25);
            this.remainderlbl.TabIndex = 63;
            this.remainderlbl.Text = "الباقي ";
            this.remainderlbl.Click += new System.EventHandler(this.remainderlbl_Click);
            // 
            // paidlbl
            // 
            this.paidlbl.AutoSize = true;
            this.paidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidlbl.Location = new System.Drawing.Point(304, 69);
            this.paidlbl.Name = "paidlbl";
            this.paidlbl.Size = new System.Drawing.Size(77, 25);
            this.paidlbl.TabIndex = 62;
            this.paidlbl.Text = "المدفوع ";
            this.paidlbl.Click += new System.EventHandler(this.paidlbl_Click);
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.Chocolate;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(353, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(181, 42);
            this.data.TabIndex = 60;
            this.data.Text = "فاتورة شراء";
            this.data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customeridlbl
            // 
            this.customeridlbl.AutoSize = true;
            this.customeridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeridlbl.Location = new System.Drawing.Point(768, 96);
            this.customeridlbl.Name = "customeridlbl";
            this.customeridlbl.Size = new System.Drawing.Size(97, 25);
            this.customeridlbl.TabIndex = 59;
            this.customeridlbl.Text = "اسم المورد";
            // 
            // bill_date
            // 
            this.bill_date.Location = new System.Drawing.Point(90, 58);
            this.bill_date.Name = "bill_date";
            this.bill_date.Size = new System.Drawing.Size(200, 20);
            this.bill_date.TabIndex = 69;
            // 
            // datlbl
            // 
            this.datlbl.AutoSize = true;
            this.datlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlbl.Location = new System.Drawing.Point(308, 55);
            this.datlbl.Name = "datlbl";
            this.datlbl.Size = new System.Drawing.Size(79, 25);
            this.datlbl.TabIndex = 70;
            this.datlbl.Text = " التاريخ ";
            // 
            // catlbl
            // 
            this.catlbl.AutoSize = true;
            this.catlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catlbl.Location = new System.Drawing.Point(711, 28);
            this.catlbl.Name = "catlbl";
            this.catlbl.Size = new System.Drawing.Size(72, 25);
            this.catlbl.TabIndex = 44;
            this.catlbl.Text = "الصنف ";
            // 
            // productcombo
            // 
            this.productcombo.FormattingEnabled = true;
            this.productcombo.Location = new System.Drawing.Point(576, 73);
            this.productcombo.Name = "productcombo";
            this.productcombo.Size = new System.Drawing.Size(121, 31);
            this.productcombo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 118);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "الكميه ";
            // 
            // product_lbl
            // 
            this.product_lbl.AutoSize = true;
            this.product_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_lbl.Location = new System.Drawing.Point(711, 71);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(72, 25);
            this.product_lbl.TabIndex = 21;
            this.product_lbl.Text = "المنتج ";
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(463, 112);
            this.quantity_textbox.Multiline = true;
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(234, 31);
            this.quantity_textbox.TabIndex = 41;
            // 
            // catcmbo
            // 
            this.catcmbo.FormattingEnabled = true;
            this.catcmbo.Location = new System.Drawing.Point(576, 30);
            this.catcmbo.Name = "catcmbo";
            this.catcmbo.Size = new System.Drawing.Size(121, 31);
            this.catcmbo.TabIndex = 45;
            this.catcmbo.SelectedIndexChanged += new System.EventHandler(this.Catcmbo_SelectedIndexChanged);
            // 
            // add_prdct
            // 
            this.add_prdct.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add_prdct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_prdct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_prdct.ForeColor = System.Drawing.Color.White;
            this.add_prdct.Location = new System.Drawing.Point(399, 222);
            this.add_prdct.Name = "add_prdct";
            this.add_prdct.Size = new System.Drawing.Size(121, 39);
            this.add_prdct.TabIndex = 51;
            this.add_prdct.Text = "أضافة منتج";
            this.add_prdct.UseVisualStyleBackColor = false;
            this.add_prdct.Click += new System.EventHandler(this.add_prdct_Click);
            // 
            // prduct_GridView1
            // 
            this.prduct_GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prduct_GridView1.Location = new System.Drawing.Point(12, 25);
            this.prduct_GridView1.Name = "prduct_GridView1";
            this.prduct_GridView1.Size = new System.Drawing.Size(367, 216);
            this.prduct_GridView1.TabIndex = 55;
            // 
            // price_lable
            // 
            this.price_lable.AutoSize = true;
            this.price_lable.Location = new System.Drawing.Point(599, 160);
            this.price_lable.Name = "price_lable";
            this.price_lable.Size = new System.Drawing.Size(0, 23);
            this.price_lable.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retrialPrice_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.whalePrice_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.price_lable);
            this.groupBox1.Controls.Add(this.prduct_GridView1);
            this.groupBox1.Controls.Add(this.add_prdct);
            this.groupBox1.Controls.Add(this.catcmbo);
            this.groupBox1.Controls.Add(this.quantity_textbox);
            this.groupBox1.Controls.Add(this.product_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productcombo);
            this.groupBox1.Controls.Add(this.catlbl);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 273);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            // 
            // retrialPrice_txt
            // 
            this.retrialPrice_txt.Location = new System.Drawing.Point(394, 162);
            this.retrialPrice_txt.Multiline = true;
            this.retrialPrice_txt.Name = "retrialPrice_txt";
            this.retrialPrice_txt.Size = new System.Drawing.Size(100, 31);
            this.retrialPrice_txt.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 165);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "سعر القطاعي";
            // 
            // whalePrice_txt
            // 
            this.whalePrice_txt.Location = new System.Drawing.Point(622, 159);
            this.whalePrice_txt.Multiline = true;
            this.whalePrice_txt.Name = "whalePrice_txt";
            this.whalePrice_txt.Size = new System.Drawing.Size(88, 31);
            this.whalePrice_txt.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 165);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "سعر الجملة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.reminLable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.paidlbl);
            this.groupBox2.Controls.Add(this.remin_lable);
            this.groupBox2.Controls.Add(this.paid_textbox);
            this.groupBox2.Controls.Add(this.remainderlbl);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(26, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 100);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اجمالي التكلفه";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(235, 26);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 23);
            this.totalLabel.TabIndex = 79;
            // 
            // reminLable
            // 
            this.reminLable.AutoSize = true;
            this.reminLable.Location = new System.Drawing.Point(33, 63);
            this.reminLable.Name = "reminLable";
            this.reminLable.Size = new System.Drawing.Size(0, 23);
            this.reminLable.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "التكلفه الكليه ";
            // 
            // receipt_to_suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sup_cmbo);
            this.Controls.Add(this.datlbl);
            this.Controls.Add(this.bill_date);
            this.Controls.Add(this.billNum);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.data);
            this.Controls.Add(this.customeridlbl);
            this.Name = "receipt_to_suppliers";
            this.Text = "فاتورة شراء";
            this.Load += new System.EventHandler(this.receipt_to_suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prduct_GridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paid_textbox;
        private System.Windows.Forms.Label remin_lable;
        private System.Windows.Forms.ComboBox sup_cmbo;
        private System.Windows.Forms.TextBox billNum;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label remainderlbl;
        private System.Windows.Forms.Label paidlbl;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label customeridlbl;
        private System.Windows.Forms.DateTimePicker bill_date;
        private System.Windows.Forms.Label datlbl;
        private System.Windows.Forms.Label catlbl;
        private System.Windows.Forms.ComboBox productcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label product_lbl;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.ComboBox catcmbo;
        private System.Windows.Forms.Button add_prdct;
        private System.Windows.Forms.DataGridView prduct_GridView1;
        private System.Windows.Forms.Label price_lable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label reminLable;
        private System.Windows.Forms.TextBox retrialPrice_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox whalePrice_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
    }
}