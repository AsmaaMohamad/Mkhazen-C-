namespace Makhazen
{
    partial class billsalesfrm
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
            this.product_lbl = new System.Windows.Forms.Label();
            this.repid_lbl = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.customeridlbl = new System.Windows.Forms.Label();
            this.paidlbl = new System.Windows.Forms.Label();
            this.remainderlbl = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.billNum = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productcombo = new System.Windows.Forms.ComboBox();
            this.catlbl = new System.Windows.Forms.Label();
            this.catcmbo = new System.Windows.Forms.ComboBox();
            this.bill_date = new System.Windows.Forms.DateTimePicker();
            this.datlbl = new System.Windows.Forms.Label();
            this.representer_combo = new System.Windows.Forms.ComboBox();
            this.cust_cmbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prouduct_gridView = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.remin_lable = new System.Windows.Forms.Label();
            this.paid_textbox = new System.Windows.Forms.TextBox();
            this.price_lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prouduct_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_lbl
            // 
            this.product_lbl.AutoSize = true;
            this.product_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_lbl.Location = new System.Drawing.Point(656, 71);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(79, 25);
            this.product_lbl.TabIndex = 21;
            this.product_lbl.Text = "المنتج :";
            // 
            // repid_lbl
            // 
            this.repid_lbl.AutoSize = true;
            this.repid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repid_lbl.Location = new System.Drawing.Point(9, 117);
            this.repid_lbl.Name = "repid_lbl";
            this.repid_lbl.Size = new System.Drawing.Size(122, 25);
            this.repid_lbl.TabIndex = 18;
            this.repid_lbl.Text = "اسم المندوب :";
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.Chocolate;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(392, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(181, 42);
            this.data.TabIndex = 15;
            this.data.Text = "فاتورة العميل";
            this.data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customeridlbl
            // 
            this.customeridlbl.AutoSize = true;
            this.customeridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeridlbl.Location = new System.Drawing.Point(430, 117);
            this.customeridlbl.Name = "customeridlbl";
            this.customeridlbl.Size = new System.Drawing.Size(109, 25);
            this.customeridlbl.TabIndex = 13;
            this.customeridlbl.Text = "اسم العميل :";
            // 
            // paidlbl
            // 
            this.paidlbl.AutoSize = true;
            this.paidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidlbl.Location = new System.Drawing.Point(47, 445);
            this.paidlbl.Name = "paidlbl";
            this.paidlbl.Size = new System.Drawing.Size(84, 25);
            this.paidlbl.TabIndex = 27;
            this.paidlbl.Text = "المدفوع :";
            // 
            // remainderlbl
            // 
            this.remainderlbl.AutoSize = true;
            this.remainderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainderlbl.Location = new System.Drawing.Point(281, 445);
            this.remainderlbl.Name = "remainderlbl";
            this.remainderlbl.Size = new System.Drawing.Size(70, 25);
            this.remainderlbl.TabIndex = 29;
            this.remainderlbl.Text = "الباقي :";
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.White;
            this.insert_btn.Location = new System.Drawing.Point(638, 437);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(98, 38);
            this.insert_btn.TabIndex = 34;
            this.insert_btn.Text = "أضافة";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Tomato;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backbtn.Location = new System.Drawing.Point(753, 437);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(98, 38);
            this.backbtn.TabIndex = 38;
            this.backbtn.Text = "رجوع";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // billNum
            // 
            this.billNum.Location = new System.Drawing.Point(137, 67);
            this.billNum.Multiline = true;
            this.billNum.Name = "billNum";
            this.billNum.Size = new System.Drawing.Size(242, 25);
            this.billNum.TabIndex = 40;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(12, 67);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(119, 25);
            this.id_lbl.TabIndex = 39;
            this.id_lbl.Text = "رقم الفاتورة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 118);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "الكميه :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // productcombo
            // 
            this.productcombo.FormattingEnabled = true;
            this.productcombo.Location = new System.Drawing.Point(521, 73);
            this.productcombo.Name = "productcombo";
            this.productcombo.Size = new System.Drawing.Size(121, 31);
            this.productcombo.TabIndex = 43;
            // 
            // catlbl
            // 
            this.catlbl.AutoSize = true;
            this.catlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catlbl.Location = new System.Drawing.Point(656, 28);
            this.catlbl.Name = "catlbl";
            this.catlbl.Size = new System.Drawing.Size(79, 25);
            this.catlbl.TabIndex = 44;
            this.catlbl.Text = "الصنف :";
            // 
            // catcmbo
            // 
            this.catcmbo.FormattingEnabled = true;
            this.catcmbo.Location = new System.Drawing.Point(521, 30);
            this.catcmbo.Name = "catcmbo";
            this.catcmbo.Size = new System.Drawing.Size(121, 31);
            this.catcmbo.TabIndex = 45;
            this.catcmbo.SelectedIndexChanged += new System.EventHandler(this.Catcmbo_SelectedIndexChanged);
            // 
            // bill_date
            // 
            this.bill_date.CustomFormat = "MM/dd/yyyy";
            this.bill_date.Location = new System.Drawing.Point(560, 70);
            this.bill_date.Name = "bill_date";
            this.bill_date.Size = new System.Drawing.Size(200, 20);
            this.bill_date.TabIndex = 46;
            // 
            // datlbl
            // 
            this.datlbl.AutoSize = true;
            this.datlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlbl.Location = new System.Drawing.Point(453, 70);
            this.datlbl.Name = "datlbl";
            this.datlbl.Size = new System.Drawing.Size(93, 25);
            this.datlbl.TabIndex = 47;
            this.datlbl.Text = " التاريخ : ";
            // 
            // representer_combo
            // 
            this.representer_combo.FormattingEnabled = true;
            this.representer_combo.Location = new System.Drawing.Point(137, 119);
            this.representer_combo.Name = "representer_combo";
            this.representer_combo.Size = new System.Drawing.Size(242, 21);
            this.representer_combo.TabIndex = 48;
            // 
            // cust_cmbo
            // 
            this.cust_cmbo.FormattingEnabled = true;
            this.cust_cmbo.Location = new System.Drawing.Point(553, 119);
            this.cust_cmbo.Name = "cust_cmbo";
            this.cust_cmbo.Size = new System.Drawing.Size(242, 21);
            this.cust_cmbo.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prouduct_gridView);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.catcmbo);
            this.groupBox1.Controls.Add(this.quantity_textbox);
            this.groupBox1.Controls.Add(this.product_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productcombo);
            this.groupBox1.Controls.Add(this.catlbl);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 247);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            // 
            // prouduct_gridView
            // 
            this.prouduct_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prouduct_gridView.Location = new System.Drawing.Point(20, 19);
            this.prouduct_gridView.Name = "prouduct_gridView";
            this.prouduct_gridView.Size = new System.Drawing.Size(367, 216);
            this.prouduct_gridView.TabIndex = 55;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(431, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 27);
            this.radioButton2.TabIndex = 53;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "جملة";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(417, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 27);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "قطاعي";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(417, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 51;
            this.button1.Text = "أضافة منتج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(408, 112);
            this.quantity_textbox.Multiline = true;
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(234, 31);
            this.quantity_textbox.TabIndex = 41;
            // 
            // remin_lable
            // 
            this.remin_lable.AutoSize = true;
            this.remin_lable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remin_lable.Location = new System.Drawing.Point(357, 450);
            this.remin_lable.Name = "remin_lable";
            this.remin_lable.Size = new System.Drawing.Size(21, 23);
            this.remin_lable.TabIndex = 58;
            this.remin_lable.Text = "0";
            // 
            // paid_textbox
            // 
            this.paid_textbox.Location = new System.Drawing.Point(133, 445);
            this.paid_textbox.Multiline = true;
            this.paid_textbox.Name = "paid_textbox";
            this.paid_textbox.Size = new System.Drawing.Size(139, 31);
            this.paid_textbox.TabIndex = 57;
            this.paid_textbox.TextChanged += new System.EventHandler(this.Paid_textbox_TextChanged);
            // 
            // price_lable
            // 
            this.price_lable.AutoSize = true;
            this.price_lable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lable.Location = new System.Drawing.Point(475, 446);
            this.price_lable.Name = "price_lable";
            this.price_lable.Size = new System.Drawing.Size(21, 23);
            this.price_lable.TabIndex = 62;
            this.price_lable.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "التكلفه :";
            // 
            // billsalesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 498);
            this.Controls.Add(this.price_lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paid_textbox);
            this.Controls.Add(this.remin_lable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cust_cmbo);
            this.Controls.Add(this.representer_combo);
            this.Controls.Add(this.datlbl);
            this.Controls.Add(this.bill_date);
            this.Controls.Add(this.billNum);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.remainderlbl);
            this.Controls.Add(this.paidlbl);
            this.Controls.Add(this.repid_lbl);
            this.Controls.Add(this.data);
            this.Controls.Add(this.customeridlbl);
            this.Name = "billsalesfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فاتورة بيع ";
            this.Load += new System.EventHandler(this.billsalesfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prouduct_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_lbl;
        private System.Windows.Forms.Label repid_lbl;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label customeridlbl;
        private System.Windows.Forms.Label paidlbl;
        private System.Windows.Forms.Label remainderlbl;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox billNum;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productcombo;
        private System.Windows.Forms.Label catlbl;
        private System.Windows.Forms.ComboBox catcmbo;
        private System.Windows.Forms.DateTimePicker bill_date;
        private System.Windows.Forms.Label datlbl;
        private System.Windows.Forms.ComboBox representer_combo;
        private System.Windows.Forms.ComboBox cust_cmbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView prouduct_gridView;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Label remin_lable;
        private System.Windows.Forms.TextBox paid_textbox;
        private System.Windows.Forms.Label price_lable;
        private System.Windows.Forms.Label label1;
    }
}