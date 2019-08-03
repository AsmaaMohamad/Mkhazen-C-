namespace Makhazen
{
    partial class permession
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.price_lable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.catcmbo = new System.Windows.Forms.ComboBox();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.product_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productcombo = new System.Windows.Forms.ComboBox();
            this.catlbl = new System.Windows.Forms.Label();
            this.representer_combo = new System.Windows.Forms.ComboBox();
            this.datlbl = new System.Windows.Forms.Label();
            this.bill_date = new System.Windows.Forms.DateTimePicker();
            this.billNum = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.repid_lbl = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.price_lable);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.catcmbo);
            this.groupBox1.Controls.Add(this.quantity_textbox);
            this.groupBox1.Controls.Add(this.product_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productcombo);
            this.groupBox1.Controls.Add(this.catlbl);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 268);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنتجات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // price_lable
            // 
            this.price_lable.AutoSize = true;
            this.price_lable.Location = new System.Drawing.Point(616, 160);
            this.price_lable.Name = "price_lable";
            this.price_lable.Size = new System.Drawing.Size(0, 23);
            this.price_lable.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 216);
            this.dataGridView1.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(417, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 51;
            this.button1.Text = "أضافة منتج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(417, 118);
            this.quantity_textbox.Multiline = true;
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(234, 31);
            this.quantity_textbox.TabIndex = 41;
            // 
            // product_lbl
            // 
            this.product_lbl.AutoSize = true;
            this.product_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_lbl.Location = new System.Drawing.Point(656, 71);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(72, 25);
            this.product_lbl.TabIndex = 21;
            this.product_lbl.Text = "المنتج ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 118);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "الكميه ";
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
            this.catlbl.Size = new System.Drawing.Size(72, 25);
            this.catlbl.TabIndex = 44;
            this.catlbl.Text = "الصنف ";
            // 
            // representer_combo
            // 
            this.representer_combo.FormattingEnabled = true;
            this.representer_combo.Location = new System.Drawing.Point(498, 104);
            this.representer_combo.Name = "representer_combo";
            this.representer_combo.Size = new System.Drawing.Size(242, 21);
            this.representer_combo.TabIndex = 71;
            // 
            // datlbl
            // 
            this.datlbl.AutoSize = true;
            this.datlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlbl.Location = new System.Drawing.Point(814, 135);
            this.datlbl.Name = "datlbl";
            this.datlbl.Size = new System.Drawing.Size(79, 25);
            this.datlbl.TabIndex = 70;
            this.datlbl.Text = " التاريخ ";
            // 
            // bill_date
            // 
            this.bill_date.Location = new System.Drawing.Point(540, 139);
            this.bill_date.Name = "bill_date";
            this.bill_date.Size = new System.Drawing.Size(200, 20);
            this.bill_date.TabIndex = 69;
            // 
            // billNum
            // 
            this.billNum.Location = new System.Drawing.Point(498, 55);
            this.billNum.Multiline = true;
            this.billNum.Name = "billNum";
            this.billNum.Size = new System.Drawing.Size(242, 25);
            this.billNum.TabIndex = 68;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(781, 49);
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
            this.backbtn.Location = new System.Drawing.Point(537, 471);
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
            this.insert_btn.Location = new System.Drawing.Point(663, 471);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(98, 38);
            this.insert_btn.TabIndex = 64;
            this.insert_btn.Text = "أضافة";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // repid_lbl
            // 
            this.repid_lbl.AutoSize = true;
            this.repid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repid_lbl.Location = new System.Drawing.Point(785, 98);
            this.repid_lbl.Name = "repid_lbl";
            this.repid_lbl.Size = new System.Drawing.Size(115, 25);
            this.repid_lbl.TabIndex = 61;
            this.repid_lbl.Text = "اسم المندوب ";
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.Chocolate;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(388, 4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(181, 42);
            this.data.TabIndex = 60;
            this.data.Text = "اذن استلام";
            this.data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // permession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.representer_combo);
            this.Controls.Add(this.datlbl);
            this.Controls.Add(this.bill_date);
            this.Controls.Add(this.billNum);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.repid_lbl);
            this.Controls.Add(this.data);
            this.Name = "permession";
            this.Text = "اذن استلام ";
            this.Load += new System.EventHandler(this.permession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label price_lable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox catcmbo;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Label product_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productcombo;
        private System.Windows.Forms.Label catlbl;
        private System.Windows.Forms.ComboBox representer_combo;
        private System.Windows.Forms.Label datlbl;
        private System.Windows.Forms.DateTimePicker bill_date;
        private System.Windows.Forms.TextBox billNum;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label repid_lbl;
        private System.Windows.Forms.Label data;
    }
}